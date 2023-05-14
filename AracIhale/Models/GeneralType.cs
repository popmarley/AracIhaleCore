namespace AracIhale.UI.Models
{
    public class GeneralType<T> where T : class
    {
        public string Message { get; set; }
        public string StatusCode { get; set; }
        public object Datas { get; set; }
    
    }
}
