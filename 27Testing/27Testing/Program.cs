using System;


// *this code is all written in java* 

namespace _27Testing
{
    class Program
    {
        // colleague 1 wrote this function to meet the given requirements
        // this is the function we're actually testing
        public static int minimum_index(int[] seq)
        {
            if (seq.length == 0)
            {
                throw new IllegalArgumentException("Cannot get the minimum value index from an empty sequence");
            }
            int min_idx = 0;
            for (int i = 1; i < seq.length; ++i)
            {
                if (seq[i] < seq[min_idx])
                {
                    min_idx = i;
                }
            }
            return min_idx;
        }

        // my task - implement the 3 classes below
        // the classes will do two things (with the exception of TestDataEmptyArray which only creates test data) 
        // 1.) produce test data
        // 2.) return the expected results given that test data
        // the purpose here is to test colleague #1's function to see if it meets the company's requirements
        static class TestDataEmptyArray
        {
            public static int[] get_array()
            {

                // return an empty array
                int[] emptyArr = new int[0];
                return emptyArr;
            }
        }

        static class TestDataUniqueValues
        {
            public static int[] get_array()
            {
                // return an array of size [2] or greater, with all unique elements
                int[] uniqueArray = { 2, 3 };
                return uniqueArray;
            }

            public static int get_expected_result()
            {
                // return the expected minium value index for the above array
                return 0;
            }
        }

        static class TestDataExactlyTwoDifferentMinimums
        {
            public static int[] get_array()
            {
                // return an array where there are exactly 2 different minimum values
                int[] twoDiffArr = { 2, 2 };
                return twoDiffArr;
            }

            public static int get_expected_result()
            {
                // return the expected minimum value index for the above array
                return 0;
            }
        }

        // colleague 2 wrote the following 3 functions
        // these function will perform the testing and validate returned results with expectations
        public static void TestWithEmptyArray()
        {
            try
            {
                int[] seq = TestDataEmptyArray.get_array();
                int result = minimum_index(seq);
            }
            catch (IllegalArgumentException e)
            {
                return;
            }
            throw new AssertionError("Exception wasn't thrown as expected");
        }

        public static void TestWithUniqueValues()
        {
            int[] seq = TestDataUniqueValues.get_array();
            if (seq.length < 2)
            {
                throw new AssertionError("less than 2 elements in the array");
            }

            Integer[] tmp = new Integer[seq.length];
            for (int i = 0; i < seq.length; ++i)
            {
                tmp[i] = Integer.valueOf(seq[i]);
            }
            if (!((new LinkedHashSet<Integer>(Arrays.asList(tmp))).size() == seq.length))
            {
                throw new AssertionError("not all values are unique");
            }

            int expected_result = TestDataUniqueValues.get_expected_result();
            int result = minimum_index(seq);
            if (result != expected_result)
            {
                throw new AssertionError("result is different than the expected result");
            }
        }

        public static void TestWithExactlyTwoDifferentMinimums()
        {
            int[] seq = TestDataExactlyTwoDifferentMinimums.get_array();
            if (seq.length < 2)
            {
                throw new AssertionError("less than 2 elements in the array");
            }

            int[] tmp = seq.clone();
            Arrays.sort(tmp);
            if (!(tmp[0] == tmp[1] && (tmp.length == 2 || tmp[1] < tmp[2])))
            {
                throw new AssertionError("there are not exactly two minimums in the array");
            }

            int expected_result = TestDataExactlyTwoDifferentMinimums.get_expected_result();
            int result = minimum_index(seq);
            if (result != expected_result)
            {
                throw new AssertionError("result is different than the expected result");
            }
        }

        // main functions calls all the test functions
        static void main(string[] args)
        {
            TestWithEmptyArray();
            TestWithUniqueValues();
            TestWithExactlyTwoDifferentMinimums();
            Console.WriteLine("Ok");
        }
    }
}
