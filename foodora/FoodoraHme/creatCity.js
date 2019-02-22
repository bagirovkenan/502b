// var Seher = function (SeherId, SeherAdi, Rayon) {
//     this.seherId = SeherId,
//         this.seheradi = SeherAdi,
//         this.rayonlar = Rayonlar
// }

// var Rayon = function (RayonId, RayonAdi, Restoran) {
//     this.rayonId = RayonId,
//         this.rayonadi = RayonAdi,
//         this.restoranlar = Restoranlar
// }

// var Restoran = function (RestoranId, RestoranAdi, Menyu) {
//     this.restoranId = RestoranId,
//         this.restorandi = RestoranAdi,
//         this.yemekler = Menyu
// }



var seherler = [
    // seher1
    {
        shrId: 1,
        shrAdi: 'Baki',
        seherImg:'baki.jpg',
        shrRayonlar: [{
                rynId: 1,
                rayonImg:'b-Nizami.jpg',
                rynAdi: 'B-Nizami',
                rynRestoran: [
                    // seher1>Rayon1
                    {
                        rstId: 1,
                        rstAdi: 'b1-Nizami Koz Doner1',
                        rstImg:'koz1.jpg',
                        Menyu: [{
                                yemekId: 1,
                                yemekAdi: 'Doner',
                                yemekimg:'doner.jpg',
                                yemekQiymeti: '2 AZN',
                            },
                            {
                                yemekId: 2,
                                yemekAdi: 'Kabab',
                                yemekimg:'kabab.jpg',
                                yemekQiymeti: '5 AZN'
                            }, {
                                yemekId: 3,
                                yemekAdi: 'Plov',
                                yemekimg:'plov.jpg',
                                yemekQiymeti: '4 AZN'
                            },
                        ]
                    },
                    {
                        rstId: 2,
                        rstAdi: 'b1-Nizami Koz Doner2',
                        rstImg:'koz2.jpg',
                        Menyu: [{
                            yemekId: 1,
                            yemekAdi: 'Doner',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '2 AZN'
                        },
                        {
                            yemekId: 2,
                            yemekAdi: 'Kabab',
                            yemekimg:'kabab.jpg',
                            yemekQiymeti: '5 AZN'
                        }, {
                            yemekId: 3,
                            yemekAdi: 'As',
                            yemekimg:'As.jpg',
                            yemekQiymeti: '4 AZN'
                        },
                    ]
                    },
                    {
                        rstId: 3,
                        rstAdi: 'b1-Nizami Koz Doner3',
                        rstImg:'koz3.jpg',
                        Menyu: [{
                            yemekId: 1,
                            yemekAdi: 'Doner',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '2 AZN'
                        },
                        {
                            yemekId: 2,
                            yemekAdi: 'Kabab',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '5 AZN'
                        }, {
                            yemekId: 3,
                            yemekAdi: 'As',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '4 AZN'
                        },
                    ]
                    },
                ]
            },
            //seher1> rayon2
            {
                rynId: 2,
                rynAdi: 'B-Nerimanov',
                rayonImg:'b-Nerimanov.jpg',
                rynRestoran: [{
                        rstId: 1,
                        rstAdi: 'b1-Nerimanov Koz Doner1',
                        rstImg:'koz1.jpg',
                        Menyu: [{
                            emekId: 1,
                            yemekAdi: 'Doner',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '2 AZN'
                        },
                        {
                            yemekId: 2,
                            yemekAdi: 'Kabab',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '5 AZN'
                        }, {
                            yemekId: 3,
                            yemekAdi: 'As',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '4 AZN'
                        },
                    ]
                    },
                    {
                        rstId: 2,
                        rstAdi: 'b1-Nerimanov Koz Doner2',
                        rstImg:'koz2.jpg',
                        Menyu: [{
                            yemekId: 1,
                            yemekAdi: 'Doner',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '2 AZN'
                        },
                        {
                            yemekId: 2,
                            yemekAdi: 'Kabab',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '5 AZN'
                        }, {
                            yemekId: 3,
                            yemekAdi: 'As',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '4 AZN'
                        },
                    ]
                    },
                    {
                        rstId: 3,
                        rstAdi: 'b1-Nerimanov Koz Doner3',
                        rstImg:'koz3.jpg',
                        Menyu: [{
                            yemekId: 1,
                            yemekAdi: 'Doner',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '2 AZN'
                        },
                        {
                            yemekId: 2,
                            yemekAdi: 'Kabab',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '5 AZN'
                        }, {
                            yemekId: 3,
                            yemekAdi: 'As',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '4 AZN'
                        },
                    ]
                    },
                ]
            },
            // seher1>rayon3
            {
                rynId: 3,
                rynAdi: 'B-Xetai',
                rayonImg:'b-Xetai.jpg',
                rynRestoran: [{
                        rstId: 1,
                        rstAdi: 'b1-Xetai Koz Doner1',
                        rstImg:'koz1.jpg',
                        Menyu: [{
                            yemekId: 1,
                            yemekAdi: 'Doner',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '2 AZN'
                        },
                        {
                            yemekId: 2,
                            yemekAdi: 'Kabab',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '5 AZN'
                        }, {
                            yemekId: 3,
                            yemekAdi: 'As',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '4 AZN'
                        },
                    ]
                    },
                    {
                        rstId: 2,
                        rstAdi: 'b2-Xetai Koz Doner2',
                        rstImg:'koz2.jpg',
                        Menyu: [{
                            yemekId: 1,
                            yemekAdi: 'Doner',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '2 AZN'
                        },
                        {
                            yemekId: 2,
                            yemekAdi: 'Kabab',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '5 AZN'
                        }, {
                            yemekId: 3,
                            yemekAdi: 'As',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '4 AZN'
                        },
                    ]
                    },
                    {
                        rstId: 3,
                        rstAdi: 'b3-Xetai Koz Doner3',
                        rstImg:'koz3.jpg',
                        Menyu: [{
                            yemekId: 1,
                            yemekAdi: 'Doner',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '2 AZN'
                        },
                        {
                            yemekId: 2,
                            yemekAdi: 'Kabab',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '5 AZN'
                        }, {
                            yemekId: 3,
                            yemekAdi: 'As',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '4 AZN'
                        },
                    ]
                    },
                ]
            },
        ]
    },
    {
        shrId: 1,
        shrAdi: 'Baki',
        seherImg:'baki.jpg',
        shrRayonlar: [{
                rynId: 1,
                rayonImg:'b-Nizami.jpg',
                rynAdi: 'B-Nizami',
                rynRestoran: [
                    // seher1>Rayon1
                    {
                        rstId: 1,
                        rstAdi: 'b1-Nizami Koz Doner1',
                        rstImg:'koz1.jpg',
                        Menyu: [{
                                yemekId: 1,
                                yemekAdi: 'Doner',
                                yemekimg:'doner.jpg',
                                yemekQiymeti: '2 AZN',
                            },
                            {
                                yemekId: 2,
                                yemekAdi: 'Kabab',
                                yemekimg:'kabab.jpg',
                                yemekQiymeti: '5 AZN'
                            }, {
                                yemekId: 3,
                                yemekAdi: 'Plov',
                                yemekimg:'plov.jpg',
                                yemekQiymeti: '4 AZN'
                            },
                        ]
                    },
                    {
                        rstId: 2,
                        rstAdi: 'b1-Nizami Koz Doner2',
                        rstImg:'koz2.jpg',
                        Menyu: [{
                            yemekId: 1,
                            yemekAdi: 'Doner',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '2 AZN'
                        },
                        {
                            yemekId: 2,
                            yemekAdi: 'Kabab',
                            yemekimg:'kabab.jpg',
                            yemekQiymeti: '5 AZN'
                        }, {
                            yemekId: 3,
                            yemekAdi: 'As',
                            yemekimg:'As.jpg',
                            yemekQiymeti: '4 AZN'
                        },
                    ]
                    },
                    {
                        rstId: 3,
                        rstAdi: 'b1-Nizami Koz Doner3',
                        rstImg:'koz3.jpg',
                        Menyu: [{
                            yemekId: 1,
                            yemekAdi: 'Doner',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '2 AZN'
                        },
                        {
                            yemekId: 2,
                            yemekAdi: 'Kabab',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '5 AZN'
                        }, {
                            yemekId: 3,
                            yemekAdi: 'As',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '4 AZN'
                        },
                    ]
                    },
                ]
            },
            //seher1> rayon2
            {
                rynId: 2,
                rynAdi: 'B-Nerimanov',
                rayonImg:'b-Nerimanov.jpg',
                rynRestoran: [{
                        rstId: 1,
                        rstAdi: 'b1-Nerimanov Koz Doner1',
                        rstImg:'koz1.jpg',
                        Menyu: [{
                            emekId: 1,
                            yemekAdi: 'Doner',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '2 AZN'
                        },
                        {
                            yemekId: 2,
                            yemekAdi: 'Kabab',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '5 AZN'
                        }, {
                            yemekId: 3,
                            yemekAdi: 'As',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '4 AZN'
                        },
                    ]
                    },
                    {
                        rstId: 2,
                        rstAdi: 'b1-Nerimanov Koz Doner2',
                        rstImg:'koz2.jpg',
                        Menyu: [{
                            yemekId: 1,
                            yemekAdi: 'Doner',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '2 AZN'
                        },
                        {
                            yemekId: 2,
                            yemekAdi: 'Kabab',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '5 AZN'
                        }, {
                            yemekId: 3,
                            yemekAdi: 'As',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '4 AZN'
                        },
                    ]
                    },
                    {
                        rstId: 3,
                        rstAdi: 'b1-Nerimanov Koz Doner3',
                        rstImg:'koz3.jpg',
                        Menyu: [{
                            yemekId: 1,
                            yemekAdi: 'Doner',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '2 AZN'
                        },
                        {
                            yemekId: 2,
                            yemekAdi: 'Kabab',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '5 AZN'
                        }, {
                            yemekId: 3,
                            yemekAdi: 'As',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '4 AZN'
                        },
                    ]
                    },
                ]
            },
            // seher1>rayon3
            {
                rynId: 3,
                rynAdi: 'B-Xetai',
                rayonImg:'b-Xetai.jpg',
                rynRestoran: [{
                        rstId: 1,
                        rstAdi: 'b1-Xetai Koz Doner1',
                        rstImg:'koz1.jpg',
                        Menyu: [{
                            yemekId: 1,
                            yemekAdi: 'Doner',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '2 AZN'
                        },
                        {
                            yemekId: 2,
                            yemekAdi: 'Kabab',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '5 AZN'
                        }, {
                            yemekId: 3,
                            yemekAdi: 'As',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '4 AZN'
                        },
                    ]
                    },
                    {
                        rstId: 2,
                        rstAdi: 'b2-Xetai Koz Doner2',
                        rstImg:'koz2.jpg',
                        Menyu: [{
                            yemekId: 1,
                            yemekAdi: 'Doner',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '2 AZN'
                        },
                        {
                            yemekId: 2,
                            yemekAdi: 'Kabab',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '5 AZN'
                        }, {
                            yemekId: 3,
                            yemekAdi: 'As',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '4 AZN'
                        },
                    ]
                    },
                    {
                        rstId: 3,
                        rstAdi: 'b3-Xetai Koz Doner3',
                        rstImg:'koz3.jpg',
                        Menyu: [{
                            yemekId: 1,
                            yemekAdi: 'Doner',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '2 AZN'
                        },
                        {
                            yemekId: 2,
                            yemekAdi: 'Kabab',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '5 AZN'
                        }, {
                            yemekId: 3,
                            yemekAdi: 'As',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '4 AZN'
                        },
                    ]
                    },
                ]
            },
        ]
    },
    {
        shrId: 1,
        shrAdi: 'Baki',
        seherImg:'baki.jpg',
        shrRayonlar: [{
                rynId: 1,
                rayonImg:'b-Nizami.jpg',
                rynAdi: 'B-Nizami',
                rynRestoran: [
                    // seher1>Rayon1
                    {
                        rstId: 1,
                        rstAdi: 'b1-Nizami Koz Doner1',
                        rstImg:'koz1.jpg',
                        Menyu: [{
                                yemekId: 1,
                                yemekAdi: 'Doner',
                                yemekimg:'doner.jpg',
                                yemekQiymeti: '2 AZN',
                            },
                            {
                                yemekId: 2,
                                yemekAdi: 'Kabab',
                                yemekimg:'kabab.jpg',
                                yemekQiymeti: '5 AZN'
                            }, {
                                yemekId: 3,
                                yemekAdi: 'Plov',
                                yemekimg:'plov.jpg',
                                yemekQiymeti: '4 AZN'
                            },
                        ]
                    },
                    {
                        rstId: 2,
                        rstAdi: 'b1-Nizami Koz Doner2',
                        rstImg:'koz2.jpg',
                        Menyu: [{
                            yemekId: 1,
                            yemekAdi: 'Doner',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '2 AZN'
                        },
                        {
                            yemekId: 2,
                            yemekAdi: 'Kabab',
                            yemekimg:'kabab.jpg',
                            yemekQiymeti: '5 AZN'
                        }, {
                            yemekId: 3,
                            yemekAdi: 'As',
                            yemekimg:'As.jpg',
                            yemekQiymeti: '4 AZN'
                        },
                    ]
                    },
                    {
                        rstId: 3,
                        rstAdi: 'b1-Nizami Koz Doner3',
                        rstImg:'koz3.jpg',
                        Menyu: [{
                            yemekId: 1,
                            yemekAdi: 'Doner',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '2 AZN'
                        },
                        {
                            yemekId: 2,
                            yemekAdi: 'Kabab',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '5 AZN'
                        }, {
                            yemekId: 3,
                            yemekAdi: 'As',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '4 AZN'
                        },
                    ]
                    },
                ]
            },
            //seher1> rayon2
            {
                rynId: 2,
                rynAdi: 'B-Nerimanov',
                rayonImg:'b-Nerimanov.jpg',
                rynRestoran: [{
                        rstId: 1,
                        rstAdi: 'b1-Nerimanov Koz Doner1',
                        rstImg:'koz1.jpg',
                        Menyu: [{
                            emekId: 1,
                            yemekAdi: 'Doner',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '2 AZN'
                        },
                        {
                            yemekId: 2,
                            yemekAdi: 'Kabab',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '5 AZN'
                        }, {
                            yemekId: 3,
                            yemekAdi: 'As',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '4 AZN'
                        },
                    ]
                    },
                    {
                        rstId: 2,
                        rstAdi: 'b1-Nerimanov Koz Doner2',
                        rstImg:'koz2.jpg',
                        Menyu: [{
                            yemekId: 1,
                            yemekAdi: 'Doner',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '2 AZN'
                        },
                        {
                            yemekId: 2,
                            yemekAdi: 'Kabab',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '5 AZN'
                        }, {
                            yemekId: 3,
                            yemekAdi: 'As',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '4 AZN'
                        },
                    ]
                    },
                    {
                        rstId: 3,
                        rstAdi: 'b1-Nerimanov Koz Doner3',
                        rstImg:'koz3.jpg',
                        Menyu: [{
                            yemekId: 1,
                            yemekAdi: 'Doner',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '2 AZN'
                        },
                        {
                            yemekId: 2,
                            yemekAdi: 'Kabab',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '5 AZN'
                        }, {
                            yemekId: 3,
                            yemekAdi: 'As',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '4 AZN'
                        },
                    ]
                    },
                ]
            },
            // seher1>rayon3
            {
                rynId: 3,
                rynAdi: 'B-Xetai',
                rayonImg:'b-Xetai.jpg',
                rynRestoran: [{
                        rstId: 1,
                        rstAdi: 'b1-Xetai Koz Doner1',
                        rstImg:'koz1.jpg',
                        Menyu: [{
                            yemekId: 1,
                            yemekAdi: 'Doner',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '2 AZN'
                        },
                        {
                            yemekId: 2,
                            yemekAdi: 'Kabab',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '5 AZN'
                        }, {
                            yemekId: 3,
                            yemekAdi: 'As',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '4 AZN'
                        },
                    ]
                    },
                    {
                        rstId: 2,
                        rstAdi: 'b2-Xetai Koz Doner2',
                        rstImg:'koz2.jpg',
                        Menyu: [{
                            yemekId: 1,
                            yemekAdi: 'Doner',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '2 AZN'
                        },
                        {
                            yemekId: 2,
                            yemekAdi: 'Kabab',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '5 AZN'
                        }, {
                            yemekId: 3,
                            yemekAdi: 'As',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '4 AZN'
                        },
                    ]
                    },
                    {
                        rstId: 3,
                        rstAdi: 'b3-Xetai Koz Doner3',
                        rstImg:'koz3.jpg',
                        Menyu: [{
                            yemekId: 1,
                            yemekAdi: 'Doner',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '2 AZN'
                        },
                        {
                            yemekId: 2,
                            yemekAdi: 'Kabab',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '5 AZN'
                        }, {
                            yemekId: 3,
                            yemekAdi: 'As',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '4 AZN'
                        },
                    ]
                    },
                ]
            },
        ]
    },
    {
        shrId: 1,
        shrAdi: 'Baki',
        seherImg:'baki.jpg',
        shrRayonlar: [{
                rynId: 1,
                rayonImg:'b-Nizami.jpg',
                rynAdi: 'B-Nizami',
                rynRestoran: [
                    // seher1>Rayon1
                    {
                        rstId: 1,
                        rstAdi: 'b1-Nizami Koz Doner1',
                        rstImg:'koz1.jpg',
                        Menyu: [{
                                yemekId: 1,
                                yemekAdi: 'Doner',
                                yemekimg:'doner.jpg',
                                yemekQiymeti: '2 AZN',
                            },
                            {
                                yemekId: 2,
                                yemekAdi: 'Kabab',
                                yemekimg:'kabab.jpg',
                                yemekQiymeti: '5 AZN'
                            }, {
                                yemekId: 3,
                                yemekAdi: 'Plov',
                                yemekimg:'plov.jpg',
                                yemekQiymeti: '4 AZN'
                            },
                        ]
                    },
                    {
                        rstId: 2,
                        rstAdi: 'b1-Nizami Koz Doner2',
                        rstImg:'koz2.jpg',
                        Menyu: [{
                            yemekId: 1,
                            yemekAdi: 'Doner',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '2 AZN'
                        },
                        {
                            yemekId: 2,
                            yemekAdi: 'Kabab',
                            yemekimg:'kabab.jpg',
                            yemekQiymeti: '5 AZN'
                        }, {
                            yemekId: 3,
                            yemekAdi: 'As',
                            yemekimg:'As.jpg',
                            yemekQiymeti: '4 AZN'
                        },
                    ]
                    },
                    {
                        rstId: 3,
                        rstAdi: 'b1-Nizami Koz Doner3',
                        rstImg:'koz3.jpg',
                        Menyu: [{
                            yemekId: 1,
                            yemekAdi: 'Doner',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '2 AZN'
                        },
                        {
                            yemekId: 2,
                            yemekAdi: 'Kabab',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '5 AZN'
                        }, {
                            yemekId: 3,
                            yemekAdi: 'As',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '4 AZN'
                        },
                    ]
                    },
                ]
            },
            //seher1> rayon2
            {
                rynId: 2,
                rynAdi: 'B-Nerimanov',
                rayonImg:'b-Nerimanov.jpg',
                rynRestoran: [{
                        rstId: 1,
                        rstAdi: 'b1-Nerimanov Koz Doner1',
                        rstImg:'koz1.jpg',
                        Menyu: [{
                            emekId: 1,
                            yemekAdi: 'Doner',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '2 AZN'
                        },
                        {
                            yemekId: 2,
                            yemekAdi: 'Kabab',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '5 AZN'
                        }, {
                            yemekId: 3,
                            yemekAdi: 'As',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '4 AZN'
                        },
                    ]
                    },
                    {
                        rstId: 2,
                        rstAdi: 'b1-Nerimanov Koz Doner2',
                        rstImg:'koz2.jpg',
                        Menyu: [{
                            yemekId: 1,
                            yemekAdi: 'Doner',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '2 AZN'
                        },
                        {
                            yemekId: 2,
                            yemekAdi: 'Kabab',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '5 AZN'
                        }, {
                            yemekId: 3,
                            yemekAdi: 'As',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '4 AZN'
                        },
                    ]
                    },
                    {
                        rstId: 3,
                        rstAdi: 'b1-Nerimanov Koz Doner3',
                        rstImg:'koz3.jpg',
                        Menyu: [{
                            yemekId: 1,
                            yemekAdi: 'Doner',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '2 AZN'
                        },
                        {
                            yemekId: 2,
                            yemekAdi: 'Kabab',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '5 AZN'
                        }, {
                            yemekId: 3,
                            yemekAdi: 'As',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '4 AZN'
                        },
                    ]
                    },
                ]
            },
            // seher1>rayon3
            {
                rynId: 3,
                rynAdi: 'B-Xetai',
                rayonImg:'b-Xetai.jpg',
                rynRestoran: [{
                        rstId: 1,
                        rstAdi: 'b1-Xetai Koz Doner1',
                        rstImg:'koz1.jpg',
                        Menyu: [{
                            yemekId: 1,
                            yemekAdi: 'Doner',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '2 AZN'
                        },
                        {
                            yemekId: 2,
                            yemekAdi: 'Kabab',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '5 AZN'
                        }, {
                            yemekId: 3,
                            yemekAdi: 'As',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '4 AZN'
                        },
                    ]
                    },
                    {
                        rstId: 2,
                        rstAdi: 'b2-Xetai Koz Doner2',
                        rstImg:'koz2.jpg',
                        Menyu: [{
                            yemekId: 1,
                            yemekAdi: 'Doner',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '2 AZN'
                        },
                        {
                            yemekId: 2,
                            yemekAdi: 'Kabab',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '5 AZN'
                        }, {
                            yemekId: 3,
                            yemekAdi: 'As',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '4 AZN'
                        },
                    ]
                    },
                    {
                        rstId: 3,
                        rstAdi: 'b3-Xetai Koz Doner3',
                        rstImg:'koz3.jpg',
                        Menyu: [{
                            yemekId: 1,
                            yemekAdi: 'Doner',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '2 AZN'
                        },
                        {
                            yemekId: 2,
                            yemekAdi: 'Kabab',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '5 AZN'
                        }, {
                            yemekId: 3,
                            yemekAdi: 'As',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '4 AZN'
                        },
                    ]
                    },
                ]
            },
        ]
    },
    // seher2
    {
        shrId: 2,
        shrAdi: 'Gence',
        seherImg:'gence.jpg',
        shrRayonlar: [
            // seher2>Rayon1
            {
                rynId: 1,
                rynAdi: 'G-Nizami',
                rayonImg:'g-Nizami.jpg',
                rynRestoran: [{
                        rstId: 1,
                        rstAdi: 'g1-Nizami Koz Doner1',
                        rstImg:'koz1.jpg',
                        Menyu: [{
                            yemekId: 1,
                            yemekAdi: 'g-Doner',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '2 AZN'
                        },
                        {
                            yemekId: 2,
                            yemekAdi: 'g-Kabab',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '5 AZN'
                        }, {
                            yemekId: 3,
                            yemekAdi: 'g-As',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '4 AZN'
                        },
                    ]
                    },
                    {
                        rstId: 2,
                        rstAdi: 'g1-Nizami Koz Doner2',
                        rstImg:'koz1.jpg',
                        Menyu: [{
                            yemekId: 1,
                            yemekAdi: 'g-Doner',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '2 AZN'
                        },
                        {
                            yemekId: 2,
                            yemekAdi: 'g-Kabab',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '5 AZN'
                        }, {
                            yemekId: 3,
                            yemekAdi: 'g-As',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '4 AZN'
                        },
                    ]
                    },
                    {
                        rstId: 3,
                        rstAdi: 'g1-Nizami Koz Doner3',
                        rstImg:'koz1.jpg',
                        Menyu: [{
                            yemekId: 1,
                            yemekAdi: 'g-Doner',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '2 AZN'
                        },
                        {
                            yemekId: 2,
                            yemekAdi: 'g-Kabab',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '5 AZN'
                        }, {
                            yemekId: 3,
                            yemekAdi: 'g-As',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '4 AZN'
                        },
                    ]
                    },
                ]
            },
            // seher2>Rayon2
            {
                rynId: 2,
                rynAdi: 'G-Nerimanov',
                rayonImg:'g-Nerimanov.jpg',
                rynRestoran: [{
                        rstId: 1,
                        rstAdi: 'g1-Nerimanov Koz Doner1',
                        rstImg:'koz1.jpg',
                        Menyu: [{
                            yemekId: 1,
                            yemekAdi: 'g-Doner',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '2 AZN'
                        },
                        {
                            yemekId: 2,
                            yemekAdi: 'g-Kabab',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '5 AZN'
                        }, {
                            yemekId: 3,
                            yemekAdi: 'g-As',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '4 AZN'
                        },
                    ]
                    },
                    {
                        rstId: 2,
                        rstAdi: 'g1-Nerimanov Koz Doner2',
                        rstImg:'koz1.jpg',
                        Menyu: [{
                            yemekId: 1,
                            yemekAdi: 'g-Doner',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '2 AZN'
                        },
                        {
                            yemekId: 2,
                            yemekAdi: 'g-Kabab',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '5 AZN'
                        }, {
                            yemekId: 3,
                            yemekAdi: 'g-As',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '4 AZN'
                        },
                    ]
                    },
                    {
                        rstId: 3,
                        rstAdi: 'g1-Nerimanov Koz Doner3',
                        rstImg:'koz1.jpg',
                        Menyu: [{
                            yemekId: 1,
                            yemekAdi: 'g-Doner',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '2 AZN'
                        },
                        {
                            yemekId: 2,
                            yemekAdi: 'g-Kabab',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '5 AZN'
                        }, {
                            yemekId: 3,
                            yemekAdi: 'g-As',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '4 AZN'
                        },
                    ]
                    },
                ]
            },
            // seher2>Rayon3
            {
                rynId: 3,
                rynAdi: 'G-Xetai',
                rayonImg:'g-Xetai.jpg',
                rynRestoran: [{
                        rstId: 1,
                        rstAdi: 'g1-Xetai Koz Doner1',
                        rstImg:'koz1.jpg',
                        Menyu: [{
                            yemekId: 1,
                            yemekAdi: 'g-Doner',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '2 AZN'
                        },
                        {
                            yemekId: 2,
                            yemekAdi: 'g-Kabab',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '5 AZN'
                        }, {
                            yemekId: 3,
                            yemekAdi: 'g-As',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '4 AZN'
                        },
                    ]
                    },
                    {
                        rstId: 2,
                        rstAdi: 'g2-Xetai Koz Doner2',
                        rstImg:'koz1.jpg',
                        Menyu: [{
                            yemekId: 1,
                            yemekAdi: 'g-Doner',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '2 AZN'
                        },
                        {
                            yemekId: 2,
                            yemekAdi: 'g-Kabab',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '5 AZN'
                        }, {
                            yemekId: 3,
                            yemekAdi: 'g-As',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '4 AZN'
                        },
                    ]
                    },
                    {
                        rstId: 3,
                        rstAdi: 'g3-Xetai Koz Doner3',
                        rstImg:'koz1.jpg',
                        Menyu: [{
                            yemekId: 1,
                            yemekAdi: 'g-Doner',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '2 AZN'
                        },
                        {
                            yemekId: 2,
                            yemekAdi: 'g-Kabab',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '5 AZN'
                        }, {
                            yemekId: 3,
                            yemekAdi: 'g-As',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '4 AZN'
                        },
                    ]
                    },
                ]
            },
        ]
    },
    // seher3
    {
        shrId: 3,
        shrAdi: 'Quba',
        seherImg:'indir.jpg',
        shrRayonlar: [
            // seher3>Rayon1
            {
                rynId: 1,
                rynAdi: 'L-Nizami',
                rayonImg:'l-NIzami.jpg',
                rynRestoran: [{
                        rstId: 1,
                        rstAdi: 'l1-Nizami Koz Doner1',
                        rstImg:'koz1.jpg',
                        Menyu: [{
                            yemekId: 1,
                            yemekAdi: 'l-Doner',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '2 AZN'
                        },
                        {
                            yemekId: 2,
                            yemekAdi: 'l-Kabab',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '5 AZN'
                        }, {
                            yemekId: 3,
                            yemekAdi: 'l-As',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '4 AZN'
                        },
                    ]
                    },
                    {
                        rstId: 2,
                        rstAdi: 'l1-Sebail Koz Doner2',
                        rstImg:'koz1.jpg',
                        Menyu: [{
                            yemekId: 1,
                            yemekAdi: 'l-Doner',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '2 AZN'
                        },
                        {
                            yemekId: 2,
                            yemekAdi: 'l-Kabab',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '5 AZN'
                        }, {
                            yemekId: 3,
                            yemekAdi: 'l-As',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '4 AZN'
                        },
                    ]
                    },
                    {
                        rstId: 3,
                        rstAdi: 'l1-Sabuncu Koz Doner3',
                        rstImg:'koz1.jpg',
                        Menyu: [{
                            yemekId: 1,
                            yemekAdi: 'l-Doner',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '2 AZN'
                        },
                        {
                            yemekId: 2,
                            yemekAdi: 'l-Kabab',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '5 AZN'
                        }, {
                            yemekId: 3,
                            yemekAdi: 'l-As',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '4 AZN'
                        },
                    ]
                    },
                ]
            },
            // seher3>Rayon2
            {
                rynId: 2,
                rynAdi: 'L-Nerimanov',
                rayonImg:'L-Nerimanov.jpg',
                rynRestoran: [{
                        rstId: 1,
                        rstAdi: 'l1-Nerimanov Koz Doner1',
                        rstImg:'koz1.jpg',
                        Menyu: [{
                            yemekId: 1,
                            yemekAdi: 'l-Doner',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '2 AZN'
                        },
                        {
                            yemekId: 2,
                            yemekAdi: 'l-Kabab',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '5 AZN'
                        }, {
                            yemekId: 3,
                            yemekAdi: 'l-As',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '4 AZN'
                        },
                    ]
                    },
                    {
                        rstId: 2,
                        rstAdi: 'l1-Nerimanov Koz Doner2',
                        rstImg:'koz1.jpg',
                        Menyu: [{
                            yemekId: 1,
                            yemekAdi: 'l-Doner',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '2 AZN'
                        },
                        {
                            yemekId: 2,
                            yemekAdi: 'l-Kabab',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '5 AZN'
                        }, {
                            yemekId: 3,
                            yemekAdi: 'l-As',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '4 AZN'
                        },
                    ]
                    },
                    {
                        rstId: 3,
                        rstAdi: 'l1-Nerimanov Koz Doner3',
                        rstImg:'koz1.jpg',
                        Menyu: [{
                            yemekId: 1,
                            yemekAdi: 'l-Doner',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '2 AZN'
                        },
                        {
                            yemekId: 2,
                            yemekAdi: 'l-Kabab',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '5 AZN'
                        }, {
                            yemekId: 3,
                            yemekAdi: 'l-As',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '4 AZN'
                        },
                    ]
                    },
                ]
            },
            // seher3>Rayon3
            {
                rynId: 3,
                rynAdi: 'L-Xetai',
                rayonImg:'L-Xetai.jpg',
                rynRestoran: [{
                        rstId: 1,
                        rstAdi: 'l1-Xetai Koz Doner1',
                        rstImg:'koz1.jpg',
                        Menyu: [{
                            yemekId: 1,
                            yemekAdi: 'l-Doner',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '2 AZN'
                        },
                        {
                            yemekId: 2,
                            yemekAdi: 'l-Kabab',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '5 AZN'
                        }, {
                            yemekId: 3,
                            yemekAdi: 'l-As',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '4 AZN'
                        },
                    ]
                    },
                    {
                        rstId: 2,
                        rstAdi: 'l2-Xetai Koz Doner2',
                        rstImg:'koz1.jpg',
                        Menyu: [{
                            yemekId: 1,
                            yemekAdi: 'l-Doner',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '2 AZN'
                        },
                        {
                            yemekId: 2,
                            yemekAdi: 'l-Kabab',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '5 AZN'
                        }, {
                            yemekId: 3,
                            yemekAdi: 'l-As',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '4 AZN'
                        },
                    ]

                    },
                    {
                        rstId: 3,
                        rstAdi: 'l3-Xetai Koz Doner3',
                        rstImg:'koz1.jpg',
                        Menyu: [{
                            yemekId: 1,
                            yemekAdi: 'l-Doner',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '2 AZN',
                        },
                        {
                            yemekId: 2,
                            yemekAdi: 'l-Kabab',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '5 AZN',
                        }, {
                            yemekId: 3,
                            yemekAdi: 'l-As',
                            yemekimg:'doner.jpg',
                            yemekQiymeti: '4 AZN',
                        },
                    ]
                    },
                ]
            },
        ]
    },
   
];
   

// htm divler
var seherEsasDiv = document.querySelector(".seherRowDiv");
var rayonEsasDiv = document.querySelector(".ryn");
var restoranEsasDiv = document.querySelector(".rst");
var menyuEsasDiv = document.querySelector(".menyu");


// creat seher divler
window.addEventListener('load', onLoad);


function onLoad() {
    // restoranEsasDiv.innerHTML = '';
    // rayonEsasDiv.innerHTML = '';
    // menyuEsasDiv.innerHTML = '';

    for (var i = 0; i < seherler.length; i++) {

        var shrDiv = document.createElement('div');
        shrDiv.className = 'col-md-2 col-sm-4 col-6 seherimgParentDiv';
        shrDiv.id = seherler[i].shrId;
      //shrDiv.style.border = 'solid 1px #e2e2e2'
     // shrDiv.innerHTML = seherler[i].shrAdi;
        shrDiv.addEventListener('click', shrClick);
        seherEsasDiv.appendChild(shrDiv);

        // creat img seher

        var shrImg = document.createElement('img');
        shrImg.className = 'seherImg';
        shrImg.setAttribute('src',seherler[i].seherImg);
        shrImg.style.width = '100%';
        shrImg.style.height = '200px';
        shrDiv.appendChild(shrImg);

        var seherSpan = document.createElement('span');
        seherSpan.className = 'seherAdiSpan',
        seherSpan.innerText = seherler[i].shrAdi;
        
        shrDiv.appendChild(seherSpan);

    }
}

// creat rayon divler 
var seherid = 0;

function shrClick() {
    seherid = this.id;
    // rayonEsasDiv.innerHTML = '';
    // restoranEsasDiv.innerHTML = '';
    // menyuEsasDiv.innerHTML = '';

    for (var x = 0; x < seherler.length; x++) {
        if (seherler[x].shrId == seherid) {
            for (var y = 0; y < seherler[x].shrRayonlar.length; y++) {
                //console.log(seherler[x].shrRayonlar[y].rynAdi)

                var rynDiv = document.createElement('div');

                rynDiv.className = 'rayonDiv';
                rynDiv.id = seherler[x].shrRayonlar[y].rynId;
                rynDiv.innerHTML = seherler[x].shrRayonlar[y].rynAdi;
                rynDiv.addEventListener('click', rynClick);
                rayonEsasDiv.appendChild(rynDiv);
            }
        }
    }
}

// creat retoranlar
var rayonid = 0;

function rynClick() {
    rayonid = this.id;
    // restoranEsasDiv.innerHTML = '';
    // menyuEsasDiv.innerHTML = '';

    for (var k = 0; k < seherler.length; k++) {


        if (seherler[k].shrId == seherid) {
            for (var g = 0; g < seherler[k].shrRayonlar.length; g++) {
                if (seherler[k].shrRayonlar[g].rynId == rayonid) {
                    for (var f = 0; f < seherler[k].shrRayonlar[g].rynRestoran.length; f++) {

                        // console.log(seherler[k].shrRayonlar[g].rynRestoran[f].rstAdi)
                        var rstDiv = document.createElement('div');
                        rstDiv.className = 'rstDiv';
                        rstDiv.id = seherler[k].shrRayonlar[g].rynRestoran[f].rstId;
                        rstDiv.innerHTML = seherler[k].shrRayonlar[g].rynRestoran[f].rstAdi;
                        rstDiv.addEventListener('click', rstClick);
                        restoranEsasDiv.appendChild(rstDiv);
                    }
                }
            }
        }
    }

}
// creat menyular 
restoranid = 0;

function rstClick() {
    // menyuEsasDiv.innerHTML = '';
    restoranid = this.id;
    // console.log(restoranid);

    for (var k = 0; k < seherler.length; k++) {
        if (seherler[k].shrId == seherid) {
            for (var g = 0; g < seherler[k].shrRayonlar.length; g++) {
                if (seherler[k].shrRayonlar[g].rynId == rayonid) {
                    for (var f = 0; f < seherler[k].shrRayonlar[g].rynRestoran.length; f++) {
                        if (seherler[k].shrRayonlar[g].rynRestoran[f].rstId == restoranid) {
                            for (var r = 0; r < seherler[k].shrRayonlar[g].rynRestoran[f].Menyu.length; r++) {

                                var yemekDiv = document.createElement('div');
                                yemekDiv.className = 'yemekdiv';
                                yemekDiv.id = seherler[k].shrRayonlar[g].rynRestoran[f].Menyu[r].yemekId;
                                yemekDiv.innerHTML = seherler[k].shrRayonlar[g].rynRestoran[f].Menyu[r].yemekAdi + '---' +seherler[k].shrRayonlar[g].rynRestoran[f].Menyu[r].yemekQiymeti;
                                menyuEsasDiv.appendChild(yemekDiv);

                            }
                        }


                    }
                }
            }
        }
    }

}