using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestCHM
{
    public class ConfigureSave
    {
        /// <summary>
        /// 保存配置
        /// </summary>
        /// <param name="fileName"></param>
        public void Save(string fileName) 
        {
            
        }
        /// <summary>
        /// 加载配置
        /// </summary>
        /// <param name="fileName"></param>
        public void Load(string fileName)
        {

        }
    }
    /// <summary>
    /// 配置信息类
    /// </summary>
    public class ConfigureInfos 
    {
        public string NodeName { get; set; } = string.Empty;

        public string ImageKey { get; set; } = string.Empty;

        public string SelectedImageKey { get; set; } = string.Empty;

        public List<ConfigureInfos> Children { get; set; } = new List<ConfigureInfos>();

        public string FilePath { get; set; } = string.Empty;
    }

}
