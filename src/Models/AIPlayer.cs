u s i n g   M i c r o s o f t . V i s u a l B a s i c ;  
 u s i n g   S y s t e m ;  
 u s i n g   S y s t e m . C o l l e c t i o n s ;  
 u s i n g   S y s t e m . C o l l e c t i o n s . G e n e r i c ;  
 u s i n g   S y s t e m . D a t a ;  
 u s i n g   S y s t e m . D i a g n o s t i c s ;  
 / / /   < s u m m a r y >  
 / / /   T h e   A I P l a y e r   i s   a   t y p e   o f   p l a y e r .   I t   c a n   r e a d o m l y   d e p l o y   s h i p s ,   i t   a l s o   h a s   t h e  
 / / /   f u n c t i o n a l i t y   t o   g e n e r a t e   c o o r d i n a t e s   a n d   s h o o t   a t   t i l e s  
 / / /   < / s u m m a r y >  
 p u b l i c   a b s t r a c t   c l a s s   A I P l a y e r   :   P l a y e r  
 {  
  
 	 / / /   < s u m m a r y >  
 	 / / /   L o c a t i o n   c a n   s t o r e   t h e   l o c a t i o n   o f   t h e   l a s t   h i t   m a d e   b y   a n  
 	 / / /   A I   P l a y e r .   T h e   u s e   o f   w h i c h   d e t e r m i n e s   t h e   d i f f i c u l t y .  
 	 / / /   < / s u m m a r y >  
 	 p r o t e c t e d   c l a s s   L o c a t i o n  
 	 {  
 	 	 p r i v a t e   i n t   _ R o w ;  
  
 	 	 p r i v a t e   i n t   _ C o l u m n ;  
 	 	 / / /   < s u m m a r y >  
 	 	 / / /   T h e   r o w   o f   t h e   s h o t  
 	 	 / / /   < / s u m m a r y >  
 	 	 / / /   < v a l u e > T h e   r o w   o f   t h e   s h o t < / v a l u e >  
 	 	 / / /   < r e t u r n s > T h e   r o w   o f   t h e   s h o t < / r e t u r n s >  
 	 	 p u b l i c   i n t   R o w   {  
 	 	 	 g e t   {   r e t u r n   _ R o w ;   }  
 	 	 	 s e t   {   _ R o w   =   v a l u e ;   }  
 	 	 }  
  
 	 	 / / /   < s u m m a r y >  
 	 	 / / /   T h e   c o l u m n   o f   t h e   s h o t  
 	 	 / / /   < / s u m m a r y >  
 	 	 / / /   < v a l u e > T h e   c o l u m n   o f   t h e   s h o t < / v a l u e >  
 	 	 / / /   < r e t u r n s > T h e   c o l u m n   o f   t h e   s h o t < / r e t u r n s >  
 	 	 p u b l i c   i n t   C o l u m n   {  
 	 	 	 g e t   {   r e t u r n   _ C o l u m n ;   }  
 	 	 	 s e t   {   _ C o l u m n   =   v a l u e ;   }  
 	 	 }  
  
 	 	 / / /   < s u m m a r y >  
 	 	 / / /   S e t s   t h e   l a s t   h i t   m a d e   t o   t h e   l o c a l   v a r i a b l e s  
 	 	 / / /   < / s u m m a r y >  
 	 	 / / /   < p a r a m   n a m e = " r o w " > t h e   r o w   o f   t h e   l o c a t i o n < / p a r a m >  
 	 	 / / /   < p a r a m   n a m e = " c o l u m n " > t h e   c o l u m n   o f   t h e   l o c a t i o n < / p a r a m >  
 	 	 p u b l i c   L o c a t i o n ( i n t   r o w ,   i n t   c o l u m n )  
 	 	 {  
 	 	 	 _ C o l u m n   =   c o l u m n ;  
 	 	 	 _ R o w   =   r o w ;  
 	 	 }  
  
 	 	 / / /   < s u m m a r y >  
 	 	 / / /   C h e c k   i f   t w o   l o c a t i o n s   a r e   e q u a l  
 	 	 / / /   < / s u m m a r y >  
 	 	 / / /   < p a r a m   n a m e = " t h i s " > l o c a t i o n   1 < / p a r a m >  
 	 	 / / /   < p a r a m   n a m e = " o t h e r " > l o c a t i o n   2 < / p a r a m >  
 	 	 / / /   < r e t u r n s > t r u e   i f   l o c a t i o n   1   a n d   l o c a t i o n   2   a r e   a t   t h e   s a m e   s p o t < / r e t u r n s >  
 	 	 p u b l i c   s t a t i c   b o o l   o p e r a t o r   = = ( L o c a t i o n   @ t h i s ,   L o c a t i o n   o t h e r )  
 	 	 {  
 	 	 	 r e t u r n   @ t h i s   ! =   n u l l   & &   o t h e r   ! =   n u l l   & &   @ t h i s . R o w   = =   o t h e r . R o w   & &   @ t h i s . C o l u m n   = =   o t h e r . C o l u m n ;  
 	 	 }  
  
 	 	 / / /   < s u m m a r y >  
 	 	 / / /   C h e c k   i f   t w o   l o c a t i o n s   a r e   n o t   e q u a l  
 	 	 / / /   < / s u m m a r y >  
 	 	 / / /   < p a r a m   n a m e = " t h i s " > l o c a t i o n   1 < / p a r a m >  
 	 	 / / /   < p a r a m   n a m e = " o t h e r " > l o c a t i o n   2 < / p a r a m >  
 	 	 / / /   < r e t u r n s > t r u e   i f   l o c a t i o n   1   a n d   l o c a t i o n   2   a r e   n o t   a t   t h e   s a m e   s p o t < / r e t u r n s >  
 	 	 p u b l i c   s t a t i c   b o o l   o p e r a t o r   ! = ( L o c a t i o n   @ t h i s ,   L o c a t i o n   o t h e r )  
 	 	 {  
 	 	 	 r e t u r n   @ t h i s   = =   n u l l   | |   o t h e r   = =   n u l l   | |   @ t h i s . R o w   ! =   o t h e r . R o w   | |   @ t h i s . C o l u m n   ! =   o t h e r . C o l u m n ;  
 	 	 }  
 	 }  
  
  
 	 p u b l i c   A I P l a y e r ( B a t t l e S h i p s G a m e   g a m e )   :   b a s e ( g a m e )  
 	 {  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   G e n e r a t e   a   v a l i d   r o w ,   c o l u m n   t o   s h o o t   a t  
 	 / / /   < / s u m m a r y >  
 	 / / /   < p a r a m   n a m e = " r o w " > o u t p u t   t h e   r o w   f o r   t h e   n e x t   s h o t < / p a r a m >  
 	 / / /   < p a r a m   n a m e = " c o l u m n " > o u t p u t   t h e   c o l u m n   f o r   t h e   n e x t   s h o w < / p a r a m >  
 	 p r o t e c t e d   a b s t r a c t   v o i d   G e n e r a t e C o o r d s ( r e f   i n t   r o w ,   r e f   i n t   c o l u m n ) ;  
  
 	 / / /   < s u m m a r y >  
 	 / / /   T h e   l a s t   s h o t   h a d   t h e   f o l l o w i n g   r e s u l t .   C h i l d   c l a s s e s   c a n   u s e   t h i s  
 	 / / /   t o   p r e p a r e   f o r   t h e   n e x t   s h o t .  
 	 / / /   < / s u m m a r y >  
 	 / / /   < p a r a m   n a m e = " r e s u l t " > T h e   r e s u l t   o f   t h e   s h o t < / p a r a m >  
 	 / / /   < p a r a m   n a m e = " r o w " > t h e   r o w   s h o t < / p a r a m >  
 	 / / /   < p a r a m   n a m e = " c o l " > t h e   c o l u m n   s h o t < / p a r a m >  
 	 p r o t e c t e d   a b s t r a c t   v o i d   P r o c e s s S h o t ( i n t   r o w ,   i n t   c o l ,   A t t a c k R e s u l t   r e s u l t ) ;  
  
 	 / / /   < s u m m a r y >  
 	 / / /   T h e   A I   t a k e s   i t s   a t t a c k s   u n t i l   i t s   g o   i s   o v e r .  
 	 / / /   < / s u m m a r y >  
 	 / / /   < r e t u r n s > T h e   r e s u l t   o f   t h e   l a s t   a t t a c k < / r e t u r n s >  
 	 p u b l i c   o v e r r i d e   A t t a c k R e s u l t   A t t a c k ( )  
 	 {  
 	 	 A t t a c k R e s u l t   r e s u l t   =   d e f a u l t ( A t t a c k R e s u l t ) ;  
 	 	 i n t   r o w   =   0 ;  
 	 	 i n t   c o l u m n   =   0 ;  
  
 	 	 / / k e e p   h i t t i n g   u n t i l   a   m i s s  
 	 	 d o   {  
 	 	 	 D e l a y ( ) ;  
  
 	 	 	 G e n e r a t e C o o r d s ( r e f   r o w ,   r e f   c o l u m n ) ;  
 	 	 	 / / g e n e r a t e   c o o r d i n a t e s   f o r   s h o t  
 	 	 	 r e s u l t   =   _ g a m e . S h o o t ( r o w ,   c o l u m n ) ;  
 	 	 	 / / t a k e   s h o t  
 	 	 	 P r o c e s s S h o t ( r o w ,   c o l u m n ,   r e s u l t ) ;  
 	 	 }   w h i l e   ( r e s u l t . V a l u e   ! =   R e s u l t O f A t t a c k . M i s s   & &   r e s u l t . V a l u e   ! =   R e s u l t O f A t t a c k . G a m e O v e r   & &   ! S w i n G a m e . W i n d o w C l o s e R e q u e s t e d ) ;  
  
 	 	 r e t u r n   r e s u l t ;  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   W a i t   a   s h o r t   p e r i o d   t o   s i m u l a t e   t h e   t h i n k   t i m e  
 	 / / /   < / s u m m a r y >  
 	 p r i v a t e   v o i d   D e l a y ( )  
 	 {  
 	 	 i n t   i   =   0 ;  
 	 	 f o r   ( i   =   0 ;   i   < =   1 5 0 ;   i + + )   {  
 	 	 	 / / D o n t   d e l a y   i f   w i n d o w   i s   c l o s e d  
 	 	 	 i f   ( S w i n G a m e . W i n d o w C l o s e R e q u e s t e d )  
 	 	 	 	 r e t u r n ;  
  
 	 	 	 S w i n G a m e . D e l a y ( 5 ) ;  
 	 	 	 S w i n G a m e . P r o c e s s E v e n t s ( ) ;  
 	 	 	 S w i n G a m e . R e f r e s h S c r e e n ( ) ;  
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
  
 