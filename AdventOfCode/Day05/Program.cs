﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Day05
{
    class Program
    {
        
        static void Main(string[] args)
        {
            bool IsStraightLine(Point point)
            {
                return point.x1 == point.x2 || point.y1 == point.y2;
            }

            

            var puzzleInput = @"409,872 -> 409,963
149,412 -> 281,280
435,281 -> 435,362
52,208 -> 969,208
427,265 -> 884,265
779,741 -> 779,738
949,41 -> 13,977
145,690 -> 145,180
513,665 -> 513,869
405,174 -> 405,612
943,504 -> 93,504
230,808 -> 570,468
69,278 -> 69,30
35,336 -> 911,336
812,83 -> 812,197
981,962 -> 29,10
863,709 -> 371,709
301,963 -> 955,309
187,101 -> 187,227
85,762 -> 85,301
587,362 -> 652,427
73,359 -> 73,139
124,449 -> 124,380
432,659 -> 30,659
96,728 -> 756,68
957,215 -> 957,868
64,779 -> 64,692
315,403 -> 854,942
890,663 -> 213,663
606,864 -> 264,864
81,446 -> 81,890
171,463 -> 395,463
766,639 -> 912,785
10,163 -> 10,835
65,906 -> 258,906
975,364 -> 408,364
595,728 -> 910,728
29,274 -> 705,274
42,965 -> 50,965
815,588 -> 959,732
293,344 -> 484,344
579,220 -> 579,949
832,951 -> 72,951
56,296 -> 56,730
318,589 -> 181,589
32,33 -> 983,984
355,794 -> 448,887
362,25 -> 696,25
374,207 -> 144,207
851,66 -> 851,709
404,98 -> 414,98
274,601 -> 787,601
898,100 -> 223,775
883,638 -> 73,638
12,989 -> 942,59
30,590 -> 146,474
46,711 -> 693,64
295,925 -> 295,854
744,89 -> 773,89
954,55 -> 33,976
647,361 -> 130,361
985,410 -> 606,410
377,884 -> 297,884
215,961 -> 981,195
176,422 -> 176,759
522,216 -> 151,216
372,149 -> 115,406
80,92 -> 218,230
350,754 -> 967,754
481,944 -> 711,714
176,795 -> 845,126
944,568 -> 944,21
86,302 -> 628,302
312,691 -> 312,640
662,874 -> 168,874
336,98 -> 336,842
289,69 -> 811,591
824,777 -> 256,209
374,311 -> 374,905
663,254 -> 137,780
183,248 -> 780,845
860,32 -> 157,32
955,794 -> 804,794
461,179 -> 96,544
780,264 -> 475,264
205,583 -> 205,645
707,364 -> 470,364
735,364 -> 551,180
127,479 -> 680,479
305,162 -> 305,85
348,349 -> 348,806
892,94 -> 88,898
340,593 -> 416,593
872,175 -> 93,954
389,750 -> 174,750
372,661 -> 949,661
121,256 -> 352,487
636,204 -> 99,741
388,328 -> 400,316
664,333 -> 549,333
89,92 -> 884,887
184,373 -> 552,741
464,949 -> 823,590
69,713 -> 767,713
302,33 -> 302,160
502,110 -> 83,529
431,331 -> 210,331
236,588 -> 931,588
931,315 -> 406,315
154,272 -> 49,272
723,159 -> 368,159
397,615 -> 402,620
431,796 -> 134,499
378,837 -> 378,670
582,28 -> 582,789
374,967 -> 445,896
723,874 -> 30,874
847,767 -> 920,767
761,101 -> 761,338
711,833 -> 419,833
953,335 -> 953,479
840,614 -> 410,614
483,485 -> 757,759
694,472 -> 694,930
508,275 -> 754,275
815,419 -> 700,534
399,843 -> 399,804
909,771 -> 95,771
796,893 -> 332,429
833,488 -> 833,899
478,240 -> 478,718
343,720 -> 343,285
320,204 -> 320,213
410,794 -> 240,964
848,227 -> 214,227
49,919 -> 880,88
273,648 -> 187,648
746,313 -> 746,590
715,527 -> 307,935
630,771 -> 630,815
780,670 -> 710,670
811,789 -> 964,789
397,267 -> 397,769
496,510 -> 744,758
314,62 -> 89,62
217,417 -> 217,865
680,862 -> 680,739
150,902 -> 816,236
504,120 -> 45,120
79,43 -> 967,931
584,197 -> 532,197
893,717 -> 489,313
609,759 -> 684,684
146,24 -> 386,24
704,645 -> 866,645
24,329 -> 44,309
417,741 -> 176,982
12,48 -> 12,138
522,359 -> 937,359
165,269 -> 55,159
207,537 -> 610,940
364,213 -> 323,213
144,750 -> 144,26
622,840 -> 488,706
909,201 -> 794,201
959,185 -> 579,565
848,720 -> 848,322
81,159 -> 81,652
98,174 -> 841,917
364,437 -> 364,568
884,90 -> 973,90
962,931 -> 60,29
915,967 -> 681,733
853,859 -> 853,809
630,362 -> 630,161
848,455 -> 672,279
50,212 -> 419,212
415,719 -> 413,719
818,274 -> 813,274
206,779 -> 206,197
251,729 -> 715,729
981,873 -> 452,344
945,708 -> 704,467
875,38 -> 76,837
163,799 -> 435,799
300,821 -> 913,208
978,15 -> 39,954
724,167 -> 191,167
342,600 -> 342,405
190,17 -> 945,772
844,659 -> 176,659
591,135 -> 50,135
252,353 -> 252,527
389,906 -> 389,861
504,387 -> 39,852
108,567 -> 108,148
60,600 -> 60,658
903,968 -> 115,180
633,34 -> 325,342
186,536 -> 708,14
588,276 -> 74,790
596,837 -> 596,909
619,278 -> 737,160
368,953 -> 245,830
112,496 -> 112,801
181,583 -> 243,521
522,293 -> 616,293
389,166 -> 418,166
792,940 -> 622,940
159,953 -> 769,343
857,231 -> 857,553
339,176 -> 339,463
35,412 -> 35,883
478,694 -> 478,325
741,257 -> 741,785
154,130 -> 810,786
869,81 -> 869,80
118,815 -> 918,815
941,954 -> 941,940
987,51 -> 56,982
243,571 -> 243,385
36,138 -> 36,24
28,971 -> 975,24
945,842 -> 759,842
474,470 -> 784,470
918,520 -> 512,114
836,606 -> 668,774
557,918 -> 422,918
925,889 -> 875,939
14,317 -> 467,770
638,312 -> 440,312
139,353 -> 212,353
690,339 -> 622,339
904,863 -> 307,266
302,939 -> 148,939
493,409 -> 93,809
185,871 -> 546,871
25,355 -> 889,355
355,832 -> 273,832
918,56 -> 38,936
950,189 -> 81,189
311,469 -> 289,469
567,269 -> 963,269
958,306 -> 958,852
847,753 -> 803,753
359,983 -> 332,956
885,128 -> 164,128
479,841 -> 350,841
850,280 -> 163,967
784,822 -> 555,822
607,29 -> 245,391
293,280 -> 293,685
273,716 -> 273,327
974,155 -> 974,415
419,34 -> 419,898
543,344 -> 543,126
137,163 -> 737,163
252,158 -> 899,805
581,36 -> 857,36
588,728 -> 588,511
320,303 -> 706,303
180,914 -> 939,155
547,676 -> 547,535
974,961 -> 97,84
179,757 -> 789,757
450,706 -> 450,452
595,598 -> 526,598
184,42 -> 184,43
221,963 -> 738,963
79,976 -> 79,109
638,793 -> 638,986
98,81 -> 534,517
700,334 -> 700,201
533,265 -> 76,265
131,839 -> 728,839
120,78 -> 815,773
455,825 -> 165,825
521,258 -> 978,258
425,931 -> 966,931
358,754 -> 506,902
126,228 -> 851,228
393,114 -> 29,114
58,615 -> 425,615
384,607 -> 581,804
140,939 -> 140,673
372,400 -> 795,400
115,165 -> 84,165
788,275 -> 544,275
126,329 -> 725,329
182,541 -> 99,541
410,709 -> 974,709
681,202 -> 687,208
495,832 -> 733,594
259,781 -> 444,596
49,442 -> 49,243
988,986 -> 18,16
224,624 -> 224,32
755,41 -> 185,611
512,168 -> 492,168
55,891 -> 762,184
162,845 -> 162,19
976,771 -> 449,244
398,789 -> 398,336
796,28 -> 796,326
589,735 -> 589,668
382,303 -> 10,675
650,968 -> 140,458
784,265 -> 245,804
961,980 -> 346,365
685,360 -> 567,360
60,847 -> 749,158
828,80 -> 46,862
96,760 -> 96,340
22,372 -> 878,372
26,973 -> 928,71
86,697 -> 86,790
684,896 -> 684,638
644,370 -> 644,177
915,854 -> 134,73
453,678 -> 453,394
716,594 -> 160,38
757,62 -> 518,301
977,928 -> 977,53
705,858 -> 328,858
352,527 -> 759,120
221,365 -> 677,821
237,815 -> 829,815
756,615 -> 756,129
681,948 -> 28,295
712,731 -> 120,731
141,292 -> 141,338
874,781 -> 874,414
197,892 -> 972,117
673,779 -> 113,219
469,240 -> 887,240
546,367 -> 270,367
115,356 -> 264,505
587,969 -> 942,969
697,332 -> 432,597
251,742 -> 251,402
655,258 -> 875,38
806,801 -> 438,801
776,525 -> 296,45
437,137 -> 437,507
310,870 -> 875,305
92,877 -> 949,20
96,695 -> 269,868
917,601 -> 917,347
598,172 -> 91,679
407,743 -> 818,743
74,932 -> 720,286
574,967 -> 747,794
989,982 -> 22,15
128,514 -> 590,976
46,86 -> 851,891
976,914 -> 87,25
948,659 -> 948,40
442,504 -> 442,398
310,824 -> 509,625
946,338 -> 433,851
555,241 -> 531,265
336,13 -> 336,48
688,880 -> 394,880
105,143 -> 823,861
761,330 -> 228,863
405,132 -> 853,580
780,886 -> 326,432
471,45 -> 471,600
810,971 -> 810,418
591,58 -> 591,821
494,133 -> 616,11
519,746 -> 519,230
696,879 -> 107,879
21,24 -> 937,940
18,822 -> 637,203
159,468 -> 570,468
635,850 -> 635,408
446,469 -> 337,469
962,690 -> 962,28
925,958 -> 40,73
123,183 -> 545,183
26,767 -> 26,548
898,101 -> 249,750
85,706 -> 85,446
224,763 -> 15,763
503,655 -> 847,655
659,905 -> 650,905
596,462 -> 851,207
421,230 -> 884,230
550,18 -> 524,18
437,375 -> 715,375
210,202 -> 210,348
263,298 -> 263,948
132,352 -> 749,969
582,454 -> 582,771
724,99 -> 724,388
16,528 -> 16,317
22,949 -> 22,987
457,328 -> 457,327
279,130 -> 279,234
56,338 -> 368,650
448,295 -> 533,295
898,90 -> 60,928
116,619 -> 208,527
614,481 -> 614,152
113,412 -> 543,412
854,305 -> 854,748
225,825 -> 115,935
976,365 -> 522,365
547,394 -> 547,82
800,695 -> 800,111
36,10 -> 973,947
557,441 -> 527,441
62,798 -> 708,798
582,585 -> 816,585
599,33 -> 70,562
971,863 -> 971,150
408,273 -> 535,273
797,215 -> 692,215
537,922 -> 519,922
299,302 -> 504,302
88,361 -> 88,249
430,311 -> 544,311
902,127 -> 902,791
346,986 -> 346,307
523,534 -> 285,296
600,628 -> 676,628
373,689 -> 945,117
265,189 -> 343,189
391,632 -> 391,728
500,516 -> 712,304
250,891 -> 41,891
591,539 -> 591,577
968,250 -> 265,250
80,32 -> 80,988
668,385 -> 323,385
407,103 -> 865,103
755,190 -> 693,190
754,113 -> 754,392
957,261 -> 967,251
881,734 -> 803,812
234,912 -> 234,326
711,893 -> 711,29
513,479 -> 782,479
111,224 -> 675,224
125,645 -> 125,502
591,983 -> 591,726
462,390 -> 85,390
854,275 -> 649,480
253,792 -> 23,792
940,975 -> 447,975
604,297 -> 604,386
172,217 -> 633,217
159,941 -> 159,569
468,72 -> 468,787
931,935 -> 36,40
114,166 -> 360,412
539,740 -> 349,930
314,342 -> 65,93
905,650 -> 817,650
786,546 -> 173,546
209,967 -> 209,142
679,64 -> 68,675
472,70 -> 840,70
750,753 -> 124,753
79,490 -> 652,490
655,114 -> 655,575
984,18 -> 984,287
458,41 -> 961,544
358,208 -> 358,679
977,830 -> 283,136
250,800 -> 187,800
64,516 -> 64,809
196,235 -> 781,235
727,988 -> 891,824
437,158 -> 437,549
565,231 -> 565,368
293,411 -> 29,147
100,905 -> 969,36
59,615 -> 920,615
844,883 -> 844,173
966,980 -> 25,39
802,923 -> 163,284
980,24 -> 730,24
357,474 -> 32,799
735,23 -> 735,566
970,426 -> 970,42
194,542 -> 194,328
372,69 -> 630,69
779,295 -> 239,835
793,381 -> 650,238
366,579 -> 366,762
502,354 -> 530,326
432,125 -> 432,795
162,220 -> 162,239
631,944 -> 63,944
261,526 -> 330,457
913,445 -> 913,958
786,160 -> 333,613
919,123 -> 88,954";

            var puzzleSplit = puzzleInput.Split("\r\n");
            List<Point> points = new List<Point>();

            foreach (var item in puzzleSplit)
            {
                var row = item.Split(" -> ");
                var beginCords = row[0].Split(",");
                var desCords = row[1].Split(",");

                int x1 = int.Parse(beginCords[0]);
                int y1 = int.Parse(beginCords[1]);
                int x2 = int.Parse(desCords[0]);
                int y2 = int.Parse(desCords[1]);

                var point = new Point
                {
                    x1 = x1,
                    y1 = y1,
                    x2 = x2,
                    y2 = y2
                };

                points.Add(point);
            }

            var yList = points.ToList();

            var visited = new Dictionary<(int x, int y), int>();

                foreach (var item in yList)
                {
                    var xDir = Math.Sign(item.x2 - item.x1);
                    var yDir = Math.Sign(item.y2 - item.y1);
                    for (int x = item.x1, y = item.y1; x != (item.x2 + xDir) || y != (item.y2 + yDir); x += xDir, y += yDir)
                        visited[(x, y)] = visited.GetValueOrDefault((x, y)) + 1;
                }
            Console.WriteLine(visited.Where(kvp => kvp.Value > 1).Count());
        }

    
    }

    class Point
    {

        public int x1;
        public int y1;
        public int x2;
        public int y2;
        
    }
}
