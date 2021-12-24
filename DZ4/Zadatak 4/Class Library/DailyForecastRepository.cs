using System;
using System.Collections.Generic;

namespace Class_Library
{
    public class DailyForecastRepository
    {
        private List<DailyForecast> dailyForecasts = new List<DailyForecast>();
        public DailyForecastRepository() {}


        // dodajemo nove dnevne prognoze, ako za neki dan vec imamo prognozu i pokusamo dodati novi prognozu na taj isti dan
        // onda se stara prognoza zamjeni novom
        public void Add(DailyForecast dailyForecast)
        {
            int flag = 0;
            for (int i = 0; i < dailyForecasts.Count; i++)
            {
                if (dailyForecasts[i].Day.Date == dailyForecast.Day.Date)
                {
                    dailyForecasts[i] = dailyForecast;
                    flag = 1;
                }
            }
            if(flag == 0)
            {
                dailyForecasts.Add(dailyForecast);
            }
        }

        // isto kao prosla, ali umjesto jednog dana, predajemo listu dana
        public void Add(List<DailyForecast> listDailyForecast)
        {
            int flag;
            for(int i = 0; i < listDailyForecast.Count; i++)
            {
                flag = 0;
                for (int j = 0; j < dailyForecasts.Count; j++)
                {
                    if (dailyForecasts[j].Day.Date == listDailyForecast[i].Day.Date)
                    {
                        dailyForecasts[j] = listDailyForecast[i];
                        flag = 1;
                    }
                }
                if (flag == 0)
                {
                    dailyForecasts.Add(listDailyForecast[i]);
                }
            }
        }

        public void Remove(DateTime date)
        {
            int flag = 0;
            for(int i = 0; i < dailyForecasts.Count; i++)
            {
                flag = 0;
                if (dailyForecasts[i].Day.Date == date.Date)
                {
                    dailyForecasts.Remove(dailyForecasts[i]);
                    flag = 1;
                }
                if (flag == 0) throw new NoSuchDailyWeatherException($"No daily forecast for {dailyForecasts[i].Weather.ToString()}");
            }
        }



    }
}
