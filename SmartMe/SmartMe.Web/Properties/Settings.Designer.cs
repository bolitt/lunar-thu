﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.1
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace SmartMe.Web.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5000")]
        public int CrawlerTimeout {
            get {
                return ((int)(this["CrawlerTimeout"]));
            }
            set {
                this["CrawlerTimeout"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 5.1; Trident/4.0; .NET CLR 2.0.5072" +
            "7; .NET CLR 3.0.04506.648; .NET CLR 3.5.21022)")]
        public string CrawlerUserAgent {
            get {
                return ((string)(this["CrawlerUserAgent"]));
            }
            set {
                this["CrawlerUserAgent"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5")]
        public int CrawlerRetryTimes {
            get {
                return ((int)(this["CrawlerRetryTimes"]));
            }
            set {
                this["CrawlerRetryTimes"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2000")]
        public int CrawlerRetryTimeoutInc {
            get {
                return ((int)(this["CrawlerRetryTimeoutInc"]));
            }
            set {
                this["CrawlerRetryTimeoutInc"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://www.google.com/search?q={0}")]
        public string GoogleSearchEngineQueryFormat {
            get {
                return ((string)(this["GoogleSearchEngineQueryFormat"]));
            }
            set {
                this["GoogleSearchEngineQueryFormat"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("utf-8")]
        public string GoogleSearchEngineEncoding {
            get {
                return ((string)(this["GoogleSearchEngineEncoding"]));
            }
            set {
                this["GoogleSearchEngineEncoding"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://www.baidu.com/s?wd={0}")]
        public string BaiduSearchEngineQueryFormat {
            get {
                return ((string)(this["BaiduSearchEngineQueryFormat"]));
            }
            set {
                this["BaiduSearchEngineQueryFormat"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("gb2312")]
        public string BaiduSearchEngineEncoding {
            get {
                return ((string)(this["BaiduSearchEngineEncoding"]));
            }
            set {
                this["BaiduSearchEngineEncoding"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://www.sogou.com/web?query={0}")]
        public string SogouSearchEngineQueryFormat {
            get {
                return ((string)(this["SogouSearchEngineQueryFormat"]));
            }
            set {
                this["SogouSearchEngineQueryFormat"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("gb2312")]
        public string SogouSearchEngineEncoding {
            get {
                return ((string)(this["SogouSearchEngineEncoding"]));
            }
            set {
                this["SogouSearchEngineEncoding"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://en.wikipedia.org/w/index.php?title=Special:Search&fulltext=Search&search={" +
            "0}")]
        public string WikipediaSearchEngineQueryFormat {
            get {
                return ((string)(this["WikipediaSearchEngineQueryFormat"]));
            }
            set {
                this["WikipediaSearchEngineQueryFormat"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("utf-8")]
        public string WikipediaSearchEngineEncoding {
            get {
                return ((string)(this["WikipediaSearchEngineEncoding"]));
            }
            set {
                this["WikipediaSearchEngineEncoding"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://dict.cn/search?q={0}")]
        public string DictCnQueryFormat {
            get {
                return ((string)(this["DictCnQueryFormat"]));
            }
            set {
                this["DictCnQueryFormat"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("gb2312")]
        public string DictCnEncoding {
            get {
                return ((string)(this["DictCnEncoding"]));
            }
            set {
                this["DictCnEncoding"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://suggestqueries.google.cn/complete/search?q={0}")]
        public string GoogleSuggestionQueryFormat {
            get {
                return ((string)(this["GoogleSuggestionQueryFormat"]));
            }
            set {
                this["GoogleSuggestionQueryFormat"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://suggestion.baidu.com/su?action=opensearch&ie=gb2312&from=ie8&wd={0}\"")]
        public string BaiduSuggestionQueryFormat {
            get {
                return ((string)(this["BaiduSuggestionQueryFormat"]));
            }
            set {
                this["BaiduSuggestionQueryFormat"] = value;
            }
        }
    }
}
