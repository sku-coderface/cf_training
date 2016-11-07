#include <stdio.h>
#include <string.h> // strlen()

int main() {
  // 배열 전체를 0으로 초기화
  char input[256] = { '\0' };

  printf("What is the input string? ");

  // scanf(" %s", input) 를 쓰면 사이에 띄어쓰기가 있으면 안 됨
  // gets(input) 은 GCC도 deprecated라고 함. 위험한 함수. 대신 fgets를 쓰면 됨.
  // sizeof(temp) 를 쓰는 아이디어: http://stackoverflow.com/a/26193030/4394750
  fgets(input, sizeof(input), stdin);
  
  // 엔터 제거
  if (input[strlen(input) - 1] == '\n') { input[strlen(input) - 1] = '\0'; }
  printf("%s has %d characters.\n", input, (int)strlen(input));
}