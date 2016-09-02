 
 u s i n g   M i c r o s o f t . V i s u a l B a s i c ;  
 u s i n g   S y s t e m ;  
 u s i n g   S y s t e m . C o l l e c t i o n s ;  
 u s i n g   S y s t e m . C o l l e c t i o n s . G e n e r i c ;  
 u s i n g   S y s t e m . D a t a ;  
 u s i n g   S y s t e m . D i a g n o s t i c s ;  
 / / /   < s u m m a r y >  
 / / /   T h e   S e a G r i d   i s   t h e   g r i d   u p o n   w h i c h   t h e   s h i p s   a r e   d e p l o y e d .  
 / / /   < / s u m m a r y >  
 / / /   < r e m a r k s >  
 / / /   T h e   g r i d   i s   v i e w a b l e   v i a   t h e   I S e a G r i d   i n t e r f a c e   a s   a   r e a d   o n l y  
 / / /   g r i d .   T h i s   c a n   b e   u s e d   i n   c o n j u n c t u r e   w i t h   t h e   S e a G r i d A d a p t e r   t o    
 / / /   m a s k   t h e   p o s i t i o n   o f   t h e   s h i p s .  
 / / /   < / r e m a r k s >  
 p u b l i c   c l a s s   S e a G r i d   :   I S e a G r i d  
 {  
  
 	 p r i v a t e   c o n s t   i n t   _ W I D T H   =   1 0 ;  
  
 	 p r i v a t e   c o n s t   i n t   _ H E I G H T   =   1 0 ;  
 	 p r i v a t e   T i l e [ , ]   _ G a m e T i l e s   =   n e w   T i l e [ W i d t h ,   H e i g h t ] ;  
 	 p r i v a t e   D i c t i o n a r y < S h i p N a m e ,   S h i p >   _ S h i p s ;  
  
 	 p r i v a t e   i n t   _ S h i p s K i l l e d   =   0 ;  
 	 / / /   < s u m m a r y >  
 	 / / /   T h e   s e a   g r i d   h a s   c h a n g e d   a n d   s h o u l d   b e   r e d r a w n .  
 	 / / /   < / s u m m a r y >  
 	 p u b l i c   e v e n t   E v e n t H a n d l e r   I S e a G r i d . C h a n g e d ;  
  
 	 / / /   < s u m m a r y >  
 	 / / /   T h e   w i d t h   o f   t h e   s e a   g r i d .  
 	 / / /   < / s u m m a r y >  
 	 / / /   < v a l u e > T h e   w i d t h   o f   t h e   s e a   g r i d . < / v a l u e >  
 	 / / /   < r e t u r n s > T h e   w i d t h   o f   t h e   s e a   g r i d . < / r e t u r n s >  
 	 p u b l i c   i n t   W i d t h   {  
 	 	 g e t   {   r e t u r n   _ W I D T H ;   }  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   T h e   h e i g h t   o f   t h e   s e a   g r i d  
 	 / / /   < / s u m m a r y >  
 	 / / /   < v a l u e > T h e   h e i g h t   o f   t h e   s e a   g r i d < / v a l u e >  
 	 / / /   < r e t u r n s > T h e   h e i g h t   o f   t h e   s e a   g r i d < / r e t u r n s >  
 	 p u b l i c   i n t   H e i g h t   {  
 	 	 g e t   {   r e t u r n   _ H E I G H T ;   }  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   S h i p s K i l l e d   r e t u r n s   t h e   n u m b e r   o f   s h i p s   k i l l e d  
 	 / / /   < / s u m m a r y >  
 	 p u b l i c   i n t   S h i p s K i l l e d   {  
 	 	 g e t   {   r e t u r n   _ S h i p s K i l l e d ;   }  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   S h o w   t h e   t i l e   v i e w  
 	 / / /   < / s u m m a r y >  
 	 / / /   < p a r a m   n a m e = " x " > x   c o o r d i n a t e   o f   t h e   t i l e < / p a r a m >  
 	 / / /   < p a r a m   n a m e = " y " > y   c o o r d i a n t e   o f   t h e   t i l e < / p a r a m >  
 	 / / /   < r e t u r n s > < / r e t u r n s >  
 	 p u b l i c   T i l e V i e w   I t e m   {  
 	 	 g e t   {   r e t u r n   _ G a m e T i l e s ( x ,   y ) . V i e w ;   }  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   A l l D e p l o y e d   c h e c k s   i f   a l l   t h e   s h i p s   a r e   d e p l o y e d  
 	 / / /   < / s u m m a r y >  
 	 p u b l i c   b o o l   A l l D e p l o y e d   {  
 	 	 g e t   {  
 	 	 	 f o r e a c h   ( S h i p   s   i n   _ S h i p s . V a l u e s )   {  
 	 	 	 	 i f   ( ! s . I s D e p l o y e d )   {  
 	 	 	 	 	 r e t u r n   f a l s e ;  
 	 	 	 	 }  
 	 	 	 }  
  
 	 	 	 r e t u r n   t r u e ;  
 	 	 }  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   S e a G r i d   c o n s t r u c t o r ,   a   s e a g r i d   h a s   a   n u m b e r   o f   t i l e s   s t o r e d   i n   a n   a r r a y  
 	 / / /   < / s u m m a r y >  
 	 p u b l i c   S e a G r i d ( D i c t i o n a r y < S h i p N a m e ,   S h i p >   s h i p s )  
 	 {  
 	 	 / / f i l l   a r r a y   w i t h   e m p t y   T i l e s  
 	 	 i n t   i   =   0 ;  
 	 	 f o r   ( i   =   0 ;   i   < =   W i d t h   -   1 ;   i + + )   {  
 	 	 	 f o r   ( i n t   j   =   0 ;   j   < =   H e i g h t   -   1 ;   j + + )   {  
 	 	 	 	 _ G a m e T i l e s ( i ,   j )   =   n e w   T i l e ( i ,   j ,   n u l l ) ;  
 	 	 	 }  
 	 	 }  
  
 	 	 _ S h i p s   =   s h i p s ;  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   M o v e S h i p s   a l l o w s   f o r   s h i p s   t o   b e   p l a c e d   o n   t h e   s e a g r i d  
 	 / / /   < / s u m m a r y >  
 	 / / /   < p a r a m   n a m e = " r o w " > t h e   r o w   s e l e c t e d < / p a r a m >  
 	 / / /   < p a r a m   n a m e = " c o l " > t h e   c o l u m n   s e l e c t e d < / p a r a m >  
 	 / / /   < p a r a m   n a m e = " s h i p " > t h e   s h i p   s e l e c t e d < / p a r a m >  
 	 / / /   < p a r a m   n a m e = " d i r e c t i o n " > t h e   d i r e c t i o n   t h e   s h i p   i s   g o i n g < / p a r a m >  
 	 p u b l i c   v o i d   M o v e S h i p ( i n t   r o w ,   i n t   c o l ,   S h i p N a m e   s h i p ,   D i r e c t i o n   d i r e c t i o n )  
 	 {  
 	 	 S h i p   n e w S h i p   =   _ S h i p s ( s h i p ) ;  
 	 	 n e w S h i p . R e m o v e ( ) ;  
 	 	 A d d S h i p ( r o w ,   c o l ,   d i r e c t i o n ,   n e w S h i p ) ;  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   A d d S h i p   a d d   a   s h i p   t o   t h e   S e a G r i d  
 	 / / /   < / s u m m a r y >  
 	 / / /   < p a r a m   n a m e = " r o w " > r o w   c o o r d i n a t e < / p a r a m >  
 	 / / /   < p a r a m   n a m e = " c o l " > c o l   c o o r d i n a t e < / p a r a m >  
 	 / / /   < p a r a m   n a m e = " d i r e c t i o n " > d i r e c t i o n   o f   s h i p < / p a r a m >  
 	 / / /   < p a r a m   n a m e = " n e w S h i p " > t h e   s h i p < / p a r a m >  
 	 p r i v a t e   v o i d   A d d S h i p ( i n t   r o w ,   i n t   c o l ,   D i r e c t i o n   d i r e c t i o n ,   S h i p   n e w S h i p )  
 	 {  
 	 	 t r y   {  
 	 	 	 i n t   s i z e   =   n e w S h i p . S i z e ;  
 	 	 	 i n t   c u r r e n t R o w   =   r o w ;  
 	 	 	 i n t   c u r r e n t C o l   =   c o l ;  
 	 	 	 i n t   d R o w   =   0 ;  
 	 	 	 i n t   d C o l   =   0 ;  
  
 	 	 	 i f   ( d i r e c t i o n   = =   d i r e c t i o n . L e f t R i g h t )   {  
 	 	 	 	 d R o w   =   0 ;  
 	 	 	 	 d C o l   =   1 ;  
 	 	 	 }   e l s e   {  
 	 	 	 	 d R o w   =   1 ;  
 	 	 	 	 d C o l   =   0 ;  
 	 	 	 }  
  
 	 	 	 / / p l a c e   s h i p ' s   t i l e s   i n   a r r a y   a n d   i n t o   s h i p   o b j e c t  
 	 	 	 i n t   i   =   0 ;  
 	 	 	 f o r   ( i   =   0 ;   i   < =   s i z e   -   1 ;   i + + )   {  
 	 	 	 	 i f   ( c u r r e n t R o w   <   0   |   c u r r e n t R o w   > =   W i d t h   |   c u r r e n t C o l   <   0   |   c u r r e n t C o l   > =   H e i g h t )   {  
 	 	 	 	 	 t h r o w   n e w   I n v a l i d O p e r a t i o n E x c e p t i o n ( " S h i p   c a n ' t   f i t   o n   t h e   b o a r d " ) ;  
 	 	 	 	 }  
  
 	 	 	 	 _ G a m e T i l e s ( c u r r e n t R o w ,   c u r r e n t C o l ) . S h i p   =   n e w S h i p ;  
  
 	 	 	 	 c u r r e n t C o l   + =   d C o l ;  
 	 	 	 	 c u r r e n t R o w   + =   d R o w ;  
 	 	 	 }  
  
 	 	 	 n e w S h i p . D e p l o y e d ( d i r e c t i o n ,   r o w ,   c o l ) ;  
 	 	 }   c a t c h   ( E x c e p t i o n   e )   {  
 	 	 	 n e w S h i p . R e m o v e ( ) ;  
 	 	 	 / / i f   f a i l s   r e m o v e   t h e   s h i p  
 	 	 	 t h r o w   n e w   A p p l i c a t i o n E x c e p t i o n ( e . M e s s a g e ) ;  
  
 	 	 }   f i n a l l y   {  
 	 	 	 i f   ( C h a n g e d   ! =   n u l l )   {  
 	 	 	 	 C h a n g e d ( t h i s ,   E v e n t A r g s . E m p t y ) ;  
 	 	 	 }  
 	 	 }  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   H i t T i l e   h i t s   a   t i l e   a t   a   r o w / c o l ,   a n d   w h a t e v e r   t i l e   h a s   b e e n   h i t ,   a  
 	 / / /   r e s u l t   w i l l   b e   d i s p l a y e d .  
 	 / / /   < / s u m m a r y >  
 	 / / /   < p a r a m   n a m e = " r o w " > t h e   r o w   a t   w h i c h   i s   b e i n g   s h o t < / p a r a m >  
 	 / / /   < p a r a m   n a m e = " c o l " > t h e   c l o u m n   a t   w h i c h   i s   b e i n g   s h o t < / p a r a m >  
 	 / / /   < r e t u r n s > A n   a t t a c k r e s u l t   ( h i t ,   m i s s ,   s u n k ,   s h o t a l r e a d y ) < / r e t u r n s >  
 	 p u b l i c   A t t a c k R e s u l t   H i t T i l e ( i n t   r o w ,   i n t   c o l )  
 	 {  
 	 	 t r y   {  
 	 	 	 / / t i l e   i s   a l r e a d y   h i t  
 	 	 	 i f   ( _ G a m e T i l e s ( r o w ,   c o l ) . S h o t )   {  
 	 	 	 	 r e t u r n   n e w   A t t a c k R e s u l t ( R e s u l t O f A t t a c k . S h o t A l r e a d y ,   " h a v e   a l r e a d y   a t t a c k e d   [ "   +   c o l   +   " , "   +   r o w   +   " ] ! " ,   r o w ,   c o l ) ;  
 	 	 	 }  
  
 	 	 	 _ G a m e T i l e s ( r o w ,   c o l ) . S h o o t ( ) ;  
  
 	 	 	 / / t h e r e   i s   n o   s h i p   o n   t h e   t i l e  
 	 	 	 i f   ( _ G a m e T i l e s ( r o w ,   c o l ) . S h i p   = =   n u l l )   {  
 	 	 	 	 r e t u r n   n e w   A t t a c k R e s u l t ( R e s u l t O f A t t a c k . M i s s ,   " m i s s e d " ,   r o w ,   c o l ) ;  
 	 	 	 }  
  
 	 	 	 / / a l l   s h i p ' s   t i l e s   h a v e   b e e n   d e s t r o y e d  
 	 	 	 i f   ( _ G a m e T i l e s ( r o w ,   c o l ) . S h i p . I s D e s t r o y e d )   {  
 	 	 	 	 _ G a m e T i l e s ( r o w ,   c o l ) . S h o t   =   t r u e ;  
 	 	 	 	 _ S h i p s K i l l e d   + =   1 ;  
 	 	 	 	 r e t u r n   n e w   A t t a c k R e s u l t ( R e s u l t O f A t t a c k . D e s t r o y e d ,   _ G a m e T i l e s ( r o w ,   c o l ) . S h i p ,   " d e s t r o y e d   t h e   e n e m y ' s " ,   r o w ,   c o l ) ;  
 	 	 	 }  
  
 	 	 	 / / e l s e   h i t   b u t   n o t   d e s t r o y e d  
 	 	 	 r e t u r n   n e w   A t t a c k R e s u l t ( R e s u l t O f A t t a c k . H i t ,   " h i t   s o m e t h i n g ! " ,   r o w ,   c o l ) ;  
 	 	 }   f i n a l l y   {  
 	 	 	 i f   ( C h a n g e d   ! =   n u l l )   {  
 	 	 	 	 C h a n g e d ( t h i s ,   E v e n t A r g s . E m p t y ) ;  
 	 	 	 }  
 	 	 }  
 	 }  
 }  
  
 / / = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =  
 / / S e r v i c e   p r o v i d e d   b y   T e l e r i k   ( w w w . t e l e r i k . c o m )  
 / / C o n v e r s i o n   p o w e r e d   b y   N R e f a c t o r y .  
 / / T w i t t e r :   @ t e l e r i k  
 / / F a c e b o o k :   f a c e b o o k . c o m / t e l e r i k  
 / / = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =  
 