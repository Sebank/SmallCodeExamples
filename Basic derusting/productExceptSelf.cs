namespace Basic_derusting
{
    public class productExceptSelf
    {
        public List<int> getProductExceptSelf(List<int> nums)
        {
            List<int> answer = new List<int>(nums);

            for (int i = 1; i < nums.Count; i++)
            {
                nums[i] *= nums[i - 1];
                answer[answer.Count - i - 1] *= answer[answer.Count - i];
            }

            for (int i = 0; i < answer.Count; i++)
            {
                answer[i] = (i > 0 ? nums[i - 1] : 1) * (i < nums.Count - 1 ? answer[i + 1] : 1);
            }

            return answer;
        }
    }
}
