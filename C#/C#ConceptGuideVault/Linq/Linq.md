## Basics
- Linq queries work on sequences or objects that implement __IEnumerable\<T>__
- The type of the variable that will hold the final result of the declarative query should be brainstorming what will be the variable in the __select__ part of the query.
- 
## Some Terminology
- Language Integrate Query
- Declarative Query Syntax
- range variable
- __PseudoCode__
```
IEnumerable<Type> variableName = 
from comic in Comics.catalog
where conditional
orderby condition ascending/descending
select Type
```

## Useful Methods
### Returns int
- Last()
- Min()
- Max()
- Sum()
- Average()
- Count()

### Returns Sequence(IEnumerable\<T>)
- Skip()
- Reverse()
- Take()
- Takelast()
- Concat()
- 