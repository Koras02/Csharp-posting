using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

public class Movies
{ 
    public string Title { get; set; }
    public DateTime ReleaseDate { get; set; }
    public double Rating { get; set; }

}

public class Group
{
    public static void Main(String[] args)
    {
        // 영화 List 생성
        var movies = new List<Movies>()
        {
            new Movies { Title = "극장판 귀멸의 칼날: 무한성편", ReleaseDate = new DateTime(2025,08,22) , Rating= 9.07 },
            new Movies { Title = "F1 더 무비", ReleaseDate = new DateTime(2025,06,25), Rating=9.07},
            new Movies { Title = "악마가 이사왔다", ReleaseDate = new DateTime(2025,08,13), Rating=6.95},
        };

        while (true)
        {
            Console.Clear();
            // 영화 선택해서 찾아보기
            Console.WriteLine("조회하실 영화 제목을 입력해주세요:");
            foreach (var movie in movies)
            {
                Console.WriteLine($"- {movie.Title}");
            }

            // 검색할 영화 제목입력
            Console.WriteLine("\n영화 제목 입력: ");
            var inputMovieTitle = Console.ReadLine()?.Trim();

            // 공백 처리
            if (string.IsNullOrEmpty(inputMovieTitle))
            {
                Console.WriteLine("영화 제목을 입력해주세요.");
                Console.ReadKey();
                continue;
            }

            // 종료 처리
            if (inputMovieTitle.Equals("exit", StringComparison.OrdinalIgnoreCase)) 
            {
                Console.WriteLine("프로그램을 종료합니다.");
                break;

            }

            // 공백 제거후 소문자로 비교
            var normalizedInput = inputMovieTitle.Replace(" ", "").ToLower();

            // 입력한 영화 제목으로 영화 찾기 = indexOf와 Whtere를 사용해 유사한 영화 제목도 검색 
            var selectedMovie = movies.Where(m => m.Title.Replace(" ", "").ToLower().Contains(normalizedInput)).ToList();

            if (selectedMovie.Count == 0)
            {
                Console.WriteLine($"\n '{inputMovieTitle}'은 없거나 개봉하지 않았습니다.");
            }
            else if (selectedMovie.Count == 1)
            {
                var movie = selectedMovie[0];
                Console.WriteLine($"\n{movie.Title}의 개봉일: {movie.ReleaseDate:yyyy-MM-dd}, 평점: {movie.Rating:F3}");
            }
            else
            {
                Console.WriteLine($"\n 입력하신 결과는 다음과 같습니다 선택: ");
                for (int i = 0; i < selectedMovie.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {selectedMovie[i].Title}");
                }

                Console.WriteLine("\n 번호를 입력해 주세요:");
                if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 1 && choice <= selectedMovie.Count)
                {
                    var movie = selectedMovie[choice - 1];
                    Console.WriteLine($"\n{movie.Title}의 개봉일: {movie.ReleaseDate:yyyy-MM-dd}, 평점: {movie.Rating:F3}");
                }
                else
                {
                    Console.WriteLine("다시 선택해 주세요");
                }
            }
            Console.WriteLine("\n 계속 검색하려면 아무키나 입력하세요");
            Console.ReadKey();
        }

    }
}