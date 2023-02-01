﻿using System;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

// ReSharper disable once CheckNamespace
namespace ComputationalGeometry {
    public static class PointComputations {
        [Pure] [NotNull] public static IEnumerable<Vector2> SimplifyPoints(IEnumerable<Vector2> PointCloud, float MinimumP2PDistance) {
            List<Vector2> SimplifiedPointCloud = new List<Vector2>();
            List<Vector2> PointsToCull = new List<Vector2>();
            float SqrP2P = MinimumP2PDistance * MinimumP2PDistance;
            IEnumerable<Vector2> IEnumerable = PointCloud.AsReadOnlyList();
            foreach (Vector2 Point in IEnumerable) {
                if (PointsToCull.Contains(Point)) continue;
                SimplifiedPointCloud.Add(Point);
                foreach (Vector2 OtherPoint in IEnumerable) {
                    if (Point == OtherPoint) continue;
                    if ((Point - OtherPoint).sqrMagnitude < SqrP2P) PointsToCull.Add(OtherPoint);
                }
            }
            return SimplifiedPointCloud;
        }
        
        private static double Cross(Vector2 O, Vector2 A, Vector2 B) {
            return (A.x - O.x) * (B.y - O.y) - (A.y - O.y) * (B.x - O.x);
        }

        [Pure] [NotNull] public static IEnumerable<Vector2> ComputeConvexHull(IEnumerable<Vector2> PointCloud) {
            List<Vector2> Points = PointCloud.ToList();
            
            if (Points.Count <= 1) return new List<Vector2>();
            int n = Points.Count(), k = 0;
            
            List<Vector2> H = new(new Vector2[2 * n]);

            Points.Sort((a, b) => Math.Abs(a.x - b.x) < 0.001f ? a.y.CompareTo(b.y) : a.x.CompareTo(b.x));
            
            for (int i = 0; i < n; ++i) {
                while (k >= 2 && Cross(H[k - 2], H[k - 1], Points[i]) <= 0)
                    k--;
                H[k++] = Points[i];
            }
            
            for (int i = n - 2, t = k + 1; i >= 0; i--) {
                while (k >= t && Cross(H[k - 2], H[k - 1], Points[i]) <= 0)
                    k--;
                H[k++] = Points[i];
            }

            return H.Take(k - 1).ToList();
        }
        
    }
}