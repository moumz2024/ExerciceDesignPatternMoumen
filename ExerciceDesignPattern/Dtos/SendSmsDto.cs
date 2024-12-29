namespace ExerciceDesignPattern.Dtos
{
    public class SendSmsDto
    {
        public string smsText { get; set; }
        public List<string> recipients { get; set; }
        public string smsTitle { get; set; }
    }
}
