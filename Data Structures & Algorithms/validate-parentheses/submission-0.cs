public class Solution {
    public bool IsValid(string s) {
        Stack<char> st = new Stack<char>();
        foreach(char bk in s){
            if (bk =='(' || bk == '{' || bk == '['){
                st.Push(bk);
            }
            else {
                if(st.Count == 0) return false;

                char top = st.Peek();
                if(
                    (bk == ')' && top == '(' ) ||
                    (bk == '}' && top == '{' ) ||
                    (bk == ']' && top == '[' ) 

                ){
                    st.Pop();
                }
                else {
                    return false;
                }
            }

        };
        if(st.Count == 0){
            return true;
        }
        else return false;
    }
}
