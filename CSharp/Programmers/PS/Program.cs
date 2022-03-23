
namespace PS
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // 2022 KAKA0 BLIND RECRUITMENT 신고 결과 받기
            var result = (new PS.Level1.RecvReportResult.Solution())
                .solution(
                new string[] { "muzi", "frodo", "apeach", "neo" }, 
                new string[] { "muzi frodo", "apeach frodo", "frodo neo", "muzi neo", "apeach muzi" }, 
                2);

            foreach (var item in result)
            {
                Console.Write(item + " ");
            }
        }
    }
}