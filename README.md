# _Word Counter_

#### _An application to determine how many times an inputted word shows up in a separate inputted sentence, 4 Oct 2019_

#### By _**Lauren Musante**_

## Specifications

| Behavior | Input | Output |
| -------- | :---------: | :---------: |
| User enters a word and a sentence that doesn't use inputted word | Word: "burrito." Sentence: "I like tacos." | "Your word shows up 0 times in your sentence." |
| User enters a word and a sentence that technically contains the inputted word, but only as part of another word" | Word: "cook." Sentence: "I love to watch a good <strong>cook</strong>ing show from time to time." | "Your word shows up 0 times in your sentence." |
| User enters a word and a sentence that contains the inputted word once | Word: "burritos." Sentence: "The only thing I miss about living in CA is the burritos." | "Your word shows up 1 time in your sentence." |
| User enters a word and a sentence that contains the inputted word twice | Word: "cat" Sentence: "My cat loves your cat." | "Your word shows up 2 times in your sentence." |



## Setup/Installation Requirements

* _Clone this repository and navigate to the "WordCounter.Solution" project directory_
* _Navigate to "WordCounter.Tests"_
* _Run the command "dotnet restore"_
* _Navigate back up to the "WordCounter" directory
* _Run the command "dotnet run"_

## Technologies Used

_C#, .NET_

### License

*Open-source*

Copyright (c) 2019 **_Lauren Musante_**