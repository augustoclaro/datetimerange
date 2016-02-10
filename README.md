# datetimerange
A simple helper to deal with datetime ranges operations.

Installation:
```sh
Install-Package DateTimeRange
```

Usage:

```sh
var startDate = new DateTime(2016, 2, 1); //Feb 1, 2016
var endDate = new DateTime(2016, 2, 10); //Feb 10, 2016

var date1 = new DateTime(2016, 2, 6); //Feb 6, 2016
var data2 = new DateTime(2016, 2, 15); //Feb 15, 2016
var date3 = new DateTime(2016, 3, 1); //Mar 1, 2016

var range = DateTimeRange.Create(startDate, endDate); //Feb 1, 2016 - Feb 10, 2016

Console.WriteLine(range.HasDate(date1)); //true
Console.WriteLine(range.HasDate(data2)); //false

var newRange1 = DateTimeRange.Create(date1, data2); //Feb 6, 2016 - Feb 15, 2016
var newRange2 = DateTimeRange.Create(data2, date3); //Feb 15, 2016 - Mar 1, 2016

Console.WriteLine(range.HasRange(newRange1)); //true
Console.WriteLine(range.HasRange(newRange2)); //false
```

Extension methods included. Usage:

```sh
var range1 = DateTime.Now.RangeUntil(DateTime.Now.AddDays(10)); //interval between today and 10 days from now
var range2 = DateTime.Now.AddDays(10).RangeSince(DateTime.Now); //interval between today and 10 days from now
```


Website article (portuguese): http://augustoclaro.com.br/datetimerange-cs-um-helper-para-trabalhar-com-intervalos-de-data/