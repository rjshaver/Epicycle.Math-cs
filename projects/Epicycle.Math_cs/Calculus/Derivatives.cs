﻿using System;
using System.Collections.Generic;
using System.Linq;

using Epicycle.Math.Geometry;

namespace Epicycle.Math.Calculus
{
    public static class Derivatives
    {
        public static double Velocity(double t1, double p1, double t2, double p2)
        {
            return (p2 - p1) / (t2 - t1);
        }

        public static double Acceleration(double t1, double p1, double t2, double p2, double t3, double p3)
        {
            var v12 = Velocity(t1, p1, t2, p2);
            var v23 = Velocity(t2, p2, t3, p3);

            return (v23 - v12) / ((t3 - t1) / 2);
        }

        public static Vector2 Velocity(double t1, Vector2 p1, double t2, Vector2 p2)
        {
            return (p2 - p1) / (t2 - t1);
        }

        public static Vector2 Acceleration(double t1, Vector2 p1, double t2, Vector2 p2, double t3, Vector2 p3)
        {
            var v12 = Velocity(t1, p1, t2, p2);
            var v23 = Velocity(t2, p2, t3, p3);

            return (v23 - v12) / ((t3 - t1) / 2);
        }

        public static Vector3 Velocity(double t1, Vector3 p1, double t2, Vector3 p2)
        {
            return (p2 - p1) / (t2 - t1);
        }

        public static Vector3 Acceleration(double t1, Vector3 p1, double t2, Vector3 p2, double t3, Vector3 p3)
        {
            var v12 = Velocity(t1, p1, t2, p2);
            var v23 = Velocity(t2, p2, t3, p3);

            return (v23 - v12) / ((t3 - t1) / 2);
        }

        public static Vector3 LeftAngularVelocity(double t1, Rotation3 r1, double t2, Rotation3 r2)
        {
            return (r2 * r1.Inv).Vector / (t2 - t1);
        }

        public static Vector3 RightAngularVelocity(double t1, Rotation3 r1, double t2, Rotation3 r2)
        {
            return (r1.Inv * r2).Vector / (t2 - t1);
        }

        public static double MidVelocity(double t1, double p1, double t2, double p2, double t3, double p3)
        {
            var eta = (t3 - t2) / (t2 - t1);

            return ((p2 - p1) * eta + (p3 - p2) / eta) / (t3 - t1);
        }

        public static Vector2 MidVelocity(double t1, Vector2 p1, double t2, Vector2 p2, double t3, Vector2 p3)
        {
            var eta = (t3 - t2) / (t2 - t1);

            return ((p2 - p1) * eta + (p3 - p2) / eta) / (t3 - t1);
        }

        public static Vector3 MidVelocity(double t1, Vector3 p1, double t2, Vector3 p2, double t3, Vector3 p3)
        {
            var eta = (t3 - t2) / (t2 - t1);

            return ((p2 - p1) * eta + (p3 - p2) / eta) / (t3 - t1);
        }
    }
}
