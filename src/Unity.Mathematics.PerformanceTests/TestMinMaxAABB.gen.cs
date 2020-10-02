//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using NUnit.Framework;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.PerformanceTesting;
using Unity.Mathematics.Geometry;
using Unity.Burst;

namespace Unity.Mathematics.PerformanceTests
{
    partial class TestMinMaxAABB
    {
        [BurstCompile(CompileSynchronously = true)]
        public unsafe class Transform_float4x4
        {
            public struct Arguments : IDisposable
            {
                public Geometry.MinMaxAABB* a;

                public void Init()
                {
                    a = (Geometry.MinMaxAABB*)UnsafeUtility.Malloc(UnsafeUtility.SizeOf<Geometry.MinMaxAABB>() * 100000, UnsafeUtility.AlignOf<Geometry.MinMaxAABB>(), Allocator.Persistent);
                    for (int i = 0; i < 100000; ++i)
                    {
                        a[i] = new Geometry.MinMaxAABB();
                    }

                }

                public void Dispose()
                {
                    UnsafeUtility.Free(a, Allocator.Persistent);
                }
            }

            public static void CommonTestFunction(ref Arguments args)
            {
                for (int i = 0; i < 100000; ++i)
                {
                    args.a[i] = Geometry.Math.Transform(float4x4.identity, args.a[i]);
                }
            }

            public static void MonoTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            [BurstCompile(CompileSynchronously = true)]
            public static void BurstTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            public delegate void TestFunction(ref Arguments args);
        }

        [Test, Performance]
        public void Transform_float4x4_mono()
        {
            Transform_float4x4.TestFunction testFunction = Transform_float4x4.MonoTestFunction;
            var args = new Transform_float4x4.Arguments();
            args.Init();

            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .Definition(sampleUnit: SampleUnit.Microsecond)
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
            args.Dispose();
        }

        [Test, Performance]
        public void Transform_float4x4_burst()
        {
            FunctionPointer<Transform_float4x4.TestFunction> testFunction = BurstCompiler.CompileFunctionPointer<Transform_float4x4.TestFunction>(Transform_float4x4.BurstTestFunction);
            var args = new Transform_float4x4.Arguments();
            args.Init();

            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .Definition(sampleUnit: SampleUnit.Microsecond)
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
            args.Dispose();
        }
        [BurstCompile(CompileSynchronously = true)]
        public unsafe class Transform_float3x3
        {
            public struct Arguments : IDisposable
            {
                public Geometry.MinMaxAABB* a;

                public void Init()
                {
                    a = (Geometry.MinMaxAABB*)UnsafeUtility.Malloc(UnsafeUtility.SizeOf<Geometry.MinMaxAABB>() * 100000, UnsafeUtility.AlignOf<Geometry.MinMaxAABB>(), Allocator.Persistent);
                    for (int i = 0; i < 100000; ++i)
                    {
                        a[i] = new Geometry.MinMaxAABB();
                    }

                }

                public void Dispose()
                {
                    UnsafeUtility.Free(a, Allocator.Persistent);
                }
            }

            public static void CommonTestFunction(ref Arguments args)
            {
                for (int i = 0; i < 100000; ++i)
                {
                    args.a[i] = Geometry.Math.Transform(float3x3.identity, args.a[i]);
                }
            }

            public static void MonoTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            [BurstCompile(CompileSynchronously = true)]
            public static void BurstTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            public delegate void TestFunction(ref Arguments args);
        }

        [Test, Performance]
        public void Transform_float3x3_mono()
        {
            Transform_float3x3.TestFunction testFunction = Transform_float3x3.MonoTestFunction;
            var args = new Transform_float3x3.Arguments();
            args.Init();

            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .Definition(sampleUnit: SampleUnit.Microsecond)
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
            args.Dispose();
        }

        [Test, Performance]
        public void Transform_float3x3_burst()
        {
            FunctionPointer<Transform_float3x3.TestFunction> testFunction = BurstCompiler.CompileFunctionPointer<Transform_float3x3.TestFunction>(Transform_float3x3.BurstTestFunction);
            var args = new Transform_float3x3.Arguments();
            args.Init();

            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .Definition(sampleUnit: SampleUnit.Microsecond)
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
            args.Dispose();
        }
        [BurstCompile(CompileSynchronously = true)]
        public unsafe class orthonormal_basis
        {
            public struct Arguments : IDisposable
            {
                public float3* v1;
                public float3* v2;
                public float3* v3;

                public void Init()
                {
                    var rng = new Random(1234u);
                    v1 = (float3*)UnsafeUtility.Malloc(UnsafeUtility.SizeOf<float3>() * 10000000, UnsafeUtility.AlignOf<float3>(), Allocator.Persistent);
                    for (int i = 0; i < 10000000; ++i)
                    {
                        v1[i] = rng.NextFloat3Direction();
                    }

                    v2 = (float3*)UnsafeUtility.Malloc(UnsafeUtility.SizeOf<float3>() * 10000000, UnsafeUtility.AlignOf<float3>(), Allocator.Persistent);
                    for (int i = 0; i < 10000000; ++i)
                    {
                        v2[i] = new float3(1.0f, 0.0f, 0.0f);
                    }

                    v3 = (float3*)UnsafeUtility.Malloc(UnsafeUtility.SizeOf<float3>() * 10000000, UnsafeUtility.AlignOf<float3>(), Allocator.Persistent);
                    for (int i = 0; i < 10000000; ++i)
                    {
                        v3[i] = new float3(1.0f, 0.0f, 0.0f);
                    }

                }

                public void Dispose()
                {
                    UnsafeUtility.Free(v1, Allocator.Persistent);
                    UnsafeUtility.Free(v2, Allocator.Persistent);
                    UnsafeUtility.Free(v3, Allocator.Persistent);
                }
            }

            public static void CommonTestFunction(ref Arguments args)
            {
                for (int i = 0; i < 10000000; ++i)
                {
                    math.orthonormal_basis(args.v1[i], out args.v2[i], out args.v3[i]);
                }
            }

            public static void MonoTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            [BurstCompile(CompileSynchronously = true)]
            public static void BurstTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            public delegate void TestFunction(ref Arguments args);
        }

        [Test, Performance]
        public void orthonormal_basis_mono()
        {
            orthonormal_basis.TestFunction testFunction = orthonormal_basis.MonoTestFunction;
            var args = new orthonormal_basis.Arguments();
            args.Init();

            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .Definition(sampleUnit: SampleUnit.Microsecond)
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
            args.Dispose();
        }

        [Test, Performance]
        public void orthonormal_basis_burst()
        {
            FunctionPointer<orthonormal_basis.TestFunction> testFunction = BurstCompiler.CompileFunctionPointer<orthonormal_basis.TestFunction>(orthonormal_basis.BurstTestFunction);
            var args = new orthonormal_basis.Arguments();
            args.Init();

            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .Definition(sampleUnit: SampleUnit.Microsecond)
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
            args.Dispose();
        }
        [BurstCompile(CompileSynchronously = true)]
        public unsafe class orthonormal_basis2
        {
            public struct Arguments : IDisposable
            {
                public float3* v1;
                public float3* v2;
                public float3* v3;

                public void Init()
                {
                    var rng = new Random(1234u);

                    v1 = (float3*)UnsafeUtility.Malloc(UnsafeUtility.SizeOf<float3>() * 10000000, UnsafeUtility.AlignOf<float3>(), Allocator.Persistent);
                    for (int i = 0; i < 10000000; ++i)
                    {
                        v1[i] = rng.NextFloat3Direction();
                    }

                    v2 = (float3*)UnsafeUtility.Malloc(UnsafeUtility.SizeOf<float3>() * 10000000, UnsafeUtility.AlignOf<float3>(), Allocator.Persistent);
                    for (int i = 0; i < 10000000; ++i)
                    {
                        v2[i] = new float3(1.0f, 0.0f, 0.0f);
                    }

                    v3 = (float3*)UnsafeUtility.Malloc(UnsafeUtility.SizeOf<float3>() * 10000000, UnsafeUtility.AlignOf<float3>(), Allocator.Persistent);
                    for (int i = 0; i < 10000000; ++i)
                    {
                        v3[i] = new float3(1.0f, 0.0f, 0.0f);
                    }

                }

                public void Dispose()
                {
                    UnsafeUtility.Free(v1, Allocator.Persistent);
                    UnsafeUtility.Free(v2, Allocator.Persistent);
                    UnsafeUtility.Free(v3, Allocator.Persistent);
                }
            }

            public static void CommonTestFunction(ref Arguments args)
            {
                for (int i = 0; i < 10000000; ++i)
                {
                    math.orthonormal_basis2(args.v1[i], out args.v2[i], out args.v3[i]);
                }
            }

            public static void MonoTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            [BurstCompile(CompileSynchronously = true)]
            public static void BurstTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            public delegate void TestFunction(ref Arguments args);
        }

        [Test, Performance]
        public void orthonormal_basis2_mono()
        {
            orthonormal_basis2.TestFunction testFunction = orthonormal_basis2.MonoTestFunction;
            var args = new orthonormal_basis2.Arguments();
            args.Init();

            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .Definition(sampleUnit: SampleUnit.Microsecond)
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
            args.Dispose();
        }

        [Test, Performance]
        public void orthonormal_basis2_burst()
        {
            FunctionPointer<orthonormal_basis2.TestFunction> testFunction = BurstCompiler.CompileFunctionPointer<orthonormal_basis2.TestFunction>(orthonormal_basis2.BurstTestFunction);
            var args = new orthonormal_basis2.Arguments();
            args.Init();

            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .Definition(sampleUnit: SampleUnit.Microsecond)
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
            args.Dispose();
        }
    }
}
