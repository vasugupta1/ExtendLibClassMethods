using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Validators;
using ExtendLibClassExample;

/*
 * In the project we can understand how to add more properties to objects which cannot be changed
 * ie they are being referenced from external nuget package.
 * Currently we have two approaches here one is to use ConditionalWeakTable and second is wrapper class
 */

var config = new ManualConfig()
 .WithOptions(ConfigOptions.DisableOptimizationsValidator)
 .AddValidator(JitOptimizationsValidator.DontFailOnError)
 .AddLogger(ConsoleLogger.Default)
 .AddColumnProvider(DefaultColumnProviders.Instance);

var summary = BenchmarkRunner.Run<UserBenchmark>(config);