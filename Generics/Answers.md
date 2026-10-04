Step 3

Compiler error:
'T' does not contain a definition for 'Id' and no accessible extension method 'Id' accepting a first argument of type 'T' could be found.

The compiler rejects this because T can represent any type, and the compiler does not know that every type used with Store<T> has an Id property.