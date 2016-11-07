#include <stdio.h>

int main() {
  // 배열 전체를 0으로 초기화
  char name[256] = { 0 };

  printf("이름이 뭔가요? ");
  scanf(" %s", name);
  printf("%s님 반갑습니다. 만나서 반가워요!\n", name);
}