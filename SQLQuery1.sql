CREATE TABLE HocSinh (
 Ten varchar(100),
 Diachi varchar(255),
 Cmnd varchar(100),
 namsinh varchar(100)
);

INSERT INTO HocSinh (Ten, Diachi, Cmnd,namsinh)
VALUES ('Nguyen Truong An', 'Ben Tre', '748329273','28/12/2003');
INSERT INTO HocSinh (Ten, Diachi, Cmnd,namsinh)
VALUES ('Nguyen Ha Quynh Giao', 'Kien Giang', '3353535','05/12/2003');
INSERT INTO HocSinh (Ten, Diachi, Cmnd,namsinh)
VALUES ('Nguyen Van Hoang', 'hcm', '5545435','01/01/2003');
INSERT INTO HocSinh (Ten, Diachi, Cmnd,namsinh)
VALUES ('Hoang Cong Manh', 'hcm', '324325325','08/01/2003');
INSERT INTO HocSinh (Ten, Diachi, Cmnd,namsinh)
VALUES ('Mai Anh Khoa', 'hcm', '345235235','01/12/2003');
select * from HocSinh;
