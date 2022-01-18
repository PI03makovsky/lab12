public static void main(String[] args) {
        date[] data = new date[2];
        date[][] data1 = new date[3][2];
        for (int i = 0; i < 2; i++) {
        data[i] = new date(12, 11, 2021);
        data[i].print();
        }
        for (int i = 0; i < 3; i++) {
        for (int j = 0; j < 2; j++) {
        data1[i][j] = new date(15, 8, 2001);
        data1[i][j].print();
        System.out.print("  ");
        }
        }
        }
        }
