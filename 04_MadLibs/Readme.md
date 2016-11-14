# 연습문제 4. Mad Libs

Mad Libs라는 간단한 게임은, 이야기 문장에 단어가 들어갈 빈칸을 만들고, 다른 사람이 채워넣어 문장을 완성하는 게임이다.

명사, 동사, 형용사, 부사를 입력받아 자신만의 이야기 문장을 만들어낼 수 있게 해보자.

## 예제 출력

영어 버전
```
Enter a noun: dog
Enter a verb: walk
Enter an adjective: blue
Enter an adverb: quickly
Do you walk your blue dog quickly? That's hilarious!
```

## 제약 조건

- 이 프로그램은 한 개의 출력문만 사용해야 함
- 쓰려는 언어가 문자열 보간 / 문자열 대치를 지원하면 출력문 생성에 사용할 것

## 도전 과제

- 입력받을 수 있는 단어를 더 늘려 이야기를 확장해보자. (파일명에 `_moreInput`)
- 대답에 따라 이야기가 분기되어 만들어지는 브랜칭 스토리를 구현해보자. 4장 참조. (파일명에 `_branching`)