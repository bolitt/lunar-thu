﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Majestic12;
using SmartMe.Core.Data;


namespace SmartMe.Web.Parse
{
	class GoogleParser: IParser
	{

		#region IParser Members

		public SearchEngineResult Parse(string html, Encoding encoding)
		{
			HTMLparser oP = HtmlParserFactory.GetInstance();
			SearchEngineResult searchResult = new SearchEngineResult();
			oP.SetEncoding(encoding);
			HTMLchunk oChunk = null;
			bool first = false;
			int state = 0;
			bool bEncodingSet = false;
			while ((oChunk = oP.ParseNext()) != null)
			{

				switch (oChunk.oType)
				{
					case  HTMLchunkType.OpenTag:
						HandleOpenTag(oChunk, ref state);

				printParams:
						if (oChunk.sTag == "meta")
						{
							HandleMetaEncoding(oP, oChunk, ref bEncodingSet);
						};
					HandleParam(oChunk, ref state);


					break;

					case HTMLchunkType.CloseTag:
					HandleCloseTag(oChunk, ref state);
						break;

					case HTMLchunkType.Text:
						HandleText(oChunk, ref state);
						break;

					default:
						break;
				}
			}

		}

		private void HandleMetaEncoding(HTMLparser oP, HTMLchunk oChunk, ref bool bEncodingSet)
		{
			// if encoding already set then we should not be trying to set new one
			// this is the logic that major browsers follow - the first Encoding is assumed to be 
			// the correct one
			if (bEncodingSet)
				return;

			if (HTMLparser.HandleMetaEncoding(oP, oChunk, ref bEncodingSet))
			{
				if (!bEncodingSet)
					Console.WriteLine("Failed to set encoding from META: {0}", oChunk.GenerateHTML());
			}
		}

		private void HandleParam(HTMLchunk oChunk, ref int state)
		{

		}

		private void HandleOpenTag(HTMLchunk oChunk, ref int state)
		{
			if (oChunk.sTag == "ol")
			{
				state = 1;
			}
			else if (oChunk.sTag == "li" && state == 1)
			{
				state = 2;
			}
			else if(oChunk.sTag== "a")
			{
				if (state == 3 || state == 5 || state == 7)
					state += 1;
			}

		}
		private void HandleCloseTag(HTMLchunk oChunk, ref int state)
		{
			if(oChunk.sTag=="ol")
			{
				state = 0;
			}
			else if(oChunk.sTag== "a")
			{
				if (state == 4 || state == 6 || state == 8)
					state += 1;
			}
		}
		private void HandleText(HTMLchunk oChunk, ref int state)
		{

		}
		#endregion
	}
}