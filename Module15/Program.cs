﻿using System;
using NLog;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module15
{
    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger(); 
        static void Main(string[] args)
        {
            // Mangler log
            logger.Trace("Enter");
            logger.Debug("Nu kaldes test1");
            test1(5, 5);
            logger.Debug("Retur fra test1");
            logger.Debug("Nu kaldes test2");
            test2();
            logger.Debug("Retur fra test2");
            logger.Trace("Exit");
        }

        static void test1(int i, int x)
        {
            // Mangler log
            logger.Trace("Enter i,x {0}, {1}", i, x);
            Console.WriteLine("test1");
            System.Threading.Thread.Sleep(3000);
            logger.Trace("Exit");
        }

        static void test2()
        {
            logger.Trace("Enter");
            try
            {
                Console.WriteLine("test2");
                throw new ApplicationException("fejl");
            }
            catch (Exception ex)
            {
                // Mangler log
                logger.Error(ex);
                            }
            logger.Trace("Exit");
        }
    }
}
