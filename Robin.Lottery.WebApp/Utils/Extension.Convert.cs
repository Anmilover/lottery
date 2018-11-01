namespace System
{
    public static class ConverterExtensions
    {
        /// <summary>
        /// ���ַ���תΪint, ���ת��ʧ��, �÷���Ĭ��ֵ
        /// </summary>
        /// <param name="number">Ҫת�����ַ���</param>
        /// <param name="defaultValue">Ĭ��ֵ</param>
        /// <returns>ת�����������ֵ</returns>
        public static int SafeToInt32(this string number, int defaultValue = default(int))
        {
            if (number == null) return defaultValue;
            if (int.TryParse(number, out var v)) return v;

            return defaultValue;
        }
    }
}