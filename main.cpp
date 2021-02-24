#include <iostream>
#include <vector>
#include <string>
#include <algorithm>

using namespace std;

void print(vector<int> vec)
{
    for(int i = 0; i < vec.size(); i++)
    {
        cout << vec[i];
    }
    cout << endl;
}

vector<int> vec_add_func(vector<int> vec)
{
    vector<int> vec_add;
    for(int i = 0; i < vec.size()-1; i++)
    {
        vec_add.push_back(0);
    }
    vec_add.push_back(1);
    return vec_add;
}

string bin_convert(char c)
{
    switch(c)
    {
        case '0': return "0000";
        case '1': return "0001";
        case '2': return "0010";
        case '3': return "0011";
        case '4': return "0100";
        case '5': return "0101";
        case '6': return "0110";
        case '7': return "0111";
        case '8': return "1000";
        case '9': return "1001";
        case 'A': return "1010";
        case 'B': return "1011";
        case 'C': return "1100";
        case 'D': return "1101";
        case 'E': return "1110";
        case 'F': return "1111";
    }
}

vector<int> convert(string text)
{
    vector <int> vec;
    int len = 0;
    int start = 0;
    int negative = 0;

    if(text[0] == '-')
    {
        start = 1;
        negative = 1;
        len = text.size() - 1;
    }
    else len = text.size();

    for(int i = 0; i < pow(2, len+1) - len * 4; i++)
    {
        vec.push_back(0);
    }

    vec[0] = negative;

    for(int i = start; i < text.size(); i++)
    {
        string data = bin_convert(text[i]);
        for(int j = 0; j < 4; j++)
            vec.push_back(data[j] - '0');
    }

    return vec;
}

vector<int> inverce_code(vector<int> vec)
{
    if(vec[0] == 1)
    {
        for(int i = 1; i < vec.size(); i++)
        {
            if(vec[i] == 0)
            {
                vec[i] = 1;
            }
            else if(vec[i] == 1)
            {
                vec[i] = 0;
            }
        }
    }
    return vec;
}



vector<int> sum(vector<int> vec_1, vector<int> vec_2)
{
    vector<int> vec;
    int c = 0;
    int a, b;

    for(int i = vec_1.size() - 1; i >= 0; i--)
    {
        a = vec_1[i];
        b = vec_2[i];
        vec.push_back(a ^ b ^ c);
        c = (a && b) || (a && c) || (b && c);
    }

    reverse(vec.begin(), vec.end());

    if(vec_1[0] == vec_2[0])
    {
        if(c == 1)
        {
            vector<int> vec_add;
            vec_add = vec_add_func(vec);
            vec = sum(vec, vec_add);
        }
    }

    return vec;
}



vector<int> additional_code(vector<int> vec)
{
    vec = inverce_code(vec);
    vector<int> vec_add = vec_add_func(vec);
    if(vec[0] == 1)
    {
        vec = sum(vec, vec_add);
    }

    return vec;
}

vector<int> change(vector<int> vec)
{
    if(vec[0] == 0)
    {
        vec[0] = 1;
        vec = additional_code(vec);
    }
    else if(vec[0] == 1)
    {
        vec = inverce_code(vec);
        vec[0] = 0;
        vector<int> vec_add;
        vec_add = vec_add_func(vec);
        vec = sum(vec, vec_add);
    }
    return vec;
}

vector<int> sub(vector<int> vec_1, vector<int> vec_2)
{
    vec_2 = change(vec_2);

    cout << "Additional code:\n";
    print(vec_2);
    cout << "\nAnswer:\n";
    return sum(vec_1, vec_2);
}


vector<int> mul(vector<int> vec_1, vector<int> vec_2)
{
    vector<int> vec;
    vector<int> vec_prev;
    for(int i = 0; i < 64; i++)
    {
        vec_prev.push_back(0);
    }

    int value_2 = vec_2[0];

    for(int i = vec_2.size() - 1; i > 0; i--)
    {
        if(vec_2[i] == 1)
        {
            vec.clear();

            for(int j = 0; j <= i ; j++)
            {
                vec.push_back(vec_1[0]);
            }
            for(int j = 0; j < vec_1.size(); j++)
            {
                vec.push_back(vec_1[j]);
            }
            for(int j = 0; j < 31 - i; j++)
            {
                vec.push_back(0);
            }

            vec = sum(vec, vec_prev);
            vec_prev = vec;

        }
    }

    if(value_2 == 1)
    {
        cout << endl<<"fffffff\n";
        for(int i = 0; i < vec_1.size(); i++)
            cout<<vec_1[i];
        vec_1 = change(vec_1);
        cout << endl<<"fffffff\n";
        for(int i = 0; i < vec_1.size(); i++)
            cout<<vec_1[i];
        cout <<"\n";

        print(vec);
        cout << endl;
        while(vec_1.size() < 64)
        {
            vec_1.push_back(0);
        }
        vec = sum(vec, vec_1);

    }
    return vec;
}



int main()
{

    string first, second;
    cout << "Enter first number:   ";
    cin >> first;
    cout << "Enter second number:   ";
    cin >> second;

    vector<int> vec_1;
    vector<int> vec_2;

    vec_1 = convert(first);
    vec_2 = convert(second);

    if(vec_1.size() < vec_2.size())
    {
        int value = 0;
        if(vec_1[0] == 0)
        {
            value = 1;
            vec_1[0] = 0;
        }
        reverse(vec_1.begin(), vec_1.end());
        for(int i = 0; i < (vec_2.size()-vec_1.size()); i++)
        {
            vec_1.push_back(0);
        }
        reverse(vec_1.begin(),vec_1.end());
        vec_1[0] = value;
    }
    else if(vec_2.size()< vec_1.size())
    {
        int value = 0;
        if(vec_2[0] == 0)
        {
            value = 1;
            vec_2[0] = 0;
        }
        reverse(vec_2.begin(), vec_2.end());
        for(int i = 0; i < (vec_1.size()-vec_2.size()); i++)
        {
            vec_2.push_back(0);
        }
        reverse(vec_2.begin(),vec_2.end());
        vec_2[0] = value;
    }

    print(vec_1);
    print(vec_2);

    cout << "What do you want?\n1)Sum;\n2)Sub;\n3)Mul;\n";
    int number = 0;
    cin >> number;

    if(number == 1)
    {
        cout << endl<<"Sum:" << endl << endl;
        vec_1 = additional_code(vec_1);
        vec_2 = additional_code(vec_2);
        cout << "Additional code:\n";
        print(vec_1);
        cout << "Additional code:\n";
        print(vec_2);

        cout << "\nAnswer:\n";
        print(sum(vec_1, vec_2));
    }
    else if(number == 2)
    {
        cout << endl<<"Sub:" << endl << endl;
        vec_1 = additional_code(vec_1);
        vec_2 = additional_code(vec_2);
        cout << "Additional code:\n";
        print(vec_1);
        print(sub(vec_1, vec_2));
    }
    else if(number == 3)
    {
        cout << endl << "Multiplication:" << endl << endl;

        vector<int> vec_add_1;
        vector<int> vec_add_2;
        vec_1 = additional_code(vec_1);
        vec_2 = additional_code(vec_2);
        cout << "Additional code:\n";
        print(vec_1);
        cout << "Additional code:\n";
        print(vec_2);

        cout << endl << "Answer " << endl;

        print(mul(vec_1, vec_2));
    }

    return 0;
}

