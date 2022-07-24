using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;

ManualConfig customConfig = DefaultConfig.Instance.WithArtifactsPath("../../../results/");
BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args, customConfig);