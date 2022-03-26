
# VietnamNumber

A library supports converting number to Vietnamese for .NET C#


## Features

- Convert number to Vietnamese words (2 modes: normal and single).
- Convert DateTime to relative time in Vietnamese.


## Installation

- Install VietnamNumber with [Nuget](https://www.nuget.org/packages/VietnamNumber/)

- Install witih .NET CLI

```bash
  dotnet add package VietnamNumber
```
## Usage

- Convert number to Vietnamese words:
```csharp
using VietnamNumber;

long numberToConvert = 1023;
string output = VienamNumber.Number.ToVietnameseWords(numberToConvert);
output = numberToConvert.ToVietnameseWords();

// Output: một nghìn không trăm hai mươi ba
```
  - Convert number by number
```csharp
using VietnamNumber;

string numberToConvert = "0123456789";
string output = VietnamNumber.Number.ToVietnameseSingleWords(numberToConvert);
// or
output = numberToConvert.ToVietnameseSingleWords();

// Output: không một hai ba bốn năm sáu bảy tám chín
```
- Convert DateTime to relative time in Vietnamese.
```csharp
using VietnamNumber;

DateTime now = new DateTime(2022, 3, 23); // current time
string output = VietnamNumber.Time.TimeAgo(now, from: new DateTime(2022, 3, 25));
// or
output = now.TimeAgo(new DateTime(2022, 3, 25));

// Output: 2 ngày trước
```
## Authors

- [Dương Bình Trọng](https://www.github.com/princ3od)
- [Phạm Đức Hoàng](https://github.com/PRID021)  
- [Trần Đặng Hoàng Anh](https://github.com/TranDangHoangAnh)
