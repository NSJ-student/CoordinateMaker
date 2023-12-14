# Coordinate Maker

개발 툴: Visual Studio 2022

개발 언어: C# winform

목적: 좌표계를 자동생성하기 위한 프로그램

사용 방법:
1. Control 그룹의 Row,Column을 편집하여 bitmap 크기를 결정
2. Bit Per Color로 사용할 색의 수를 결정 (BitPerColor=n일 때 색의 수=2^n)
3. 색 리스트의 항목을 더블클릭하여 색을 결정
4. 비트맵 편집
  - Brush/Fill 토글버튼을 누르고 비트맵 칸을 클릭하여 원하는 그림을 그림
  - Brush=선택한 칸만 색칠, Fill=선택한 칸과 연결되면서 색이 같은 모든 영역을 색칠
  - 색 리스트의 항목을 선택하여 Brush/Fill할 색을 결정
5. Make버튼을 눌러 565RGB로 변환한 배열값을 생성

