``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1826 (21H2)
AMD Ryzen 5 5600X, 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.302
  [Host]     : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
  DefaultJob : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT


```
|          Method |     Mean |     Error |    StdDev |
|---------------- |---------:|----------:|----------:|
| BenchmarkKenny1 | 4.798 μs | 0.0409 μs | 0.0383 μs |
| BenchmarkKenny2 | 1.650 μs | 0.0063 μs | 0.0058 μs |
| BenchmarkKenny3 | 2.945 μs | 0.0149 μs | 0.0139 μs |
