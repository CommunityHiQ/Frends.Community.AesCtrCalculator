using System.ComponentModel.DataAnnotations;

namespace Frends.Community.AesCtrCalculator
{
    #region Classes
    public class Input
    {
        /// <summary>
        /// Secret key
        /// </summary>
        [DisplayFormat(DataFormatString = "Text")]
        public string Key { get; set; }
        /// <summary>
        /// IV
        /// </summary>
        [DisplayFormat(DataFormatString = "Text")]
        public string Iv { get; set; }
        /// <summary>
        /// Data to encrypt / decrypt
        /// </summary>
        [DisplayFormat(DataFormatString = "Text")]
        public string Data { get; set; }
    }


    public class Output
    {
        /// <summary>
        /// CTR calculation result
        /// </summary>
        public string Data { get; set; }
    }
    #endregion
}
