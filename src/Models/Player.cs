u s i n g   M i c r o s o f t . V i s u a l B a s i c ;  
 u s i n g   S y s t e m ;  
 u s i n g   S y s t e m . C o l l e c t i o n s ;  
 u s i n g   S y s t e m . C o l l e c t i o n s . G e n e r i c ;  
 u s i n g   S y s t e m . D a t a ;  
 u s i n g   S y s t e m . D i a g n o s t i c s ;  
 / / /   < s u m m a r y >  
 / / /   P l a y e r   h a s   i t s   o w n   _ P l a y e r G r i d ,   a n d   c a n   s e e   a n   _ E n e m y G r i d ,   i t   c a n   a l s o   c h e c k   i f  
 / / /   a l l   s h i p s   a r e   d e p l o y e d   a n d   i f   a l l   s h i p s   a r e   d e t r o y e d .   A   P l a y e r   c a n   a l s o   a t t a c h .  
 / / /   < / s u m m a r y > namespace BattleShips{ 
 p u b l i c   c l a s s   P l a y e r   :   I E n u m e r a b l e < S h i p >  
 {  
  
 	 p r o t e c t e d   s t a t i c   R a n d o m   _ R a n d o m   =   n e w   R a n d o m ( ) ;  
 	 p r i v a t e   D i c t i o n a r y < S h i p N a m e ,   S h i p >   _ S h i p s   =   n e w   D i c t i o n a r y < S h i p N a m e ,   S h i p > ( ) ;  
 	 p r i v a t e   S e a G r i d   _ p l a y e r G r i d   =   n e w   S e a G r i d ( _ S h i p s ) ;  
 	 p r i v a t e   I S e a G r i d   _ e n e m y G r i d ;  
  
 	 p r o t e c t e d   B a t t l e S h i p s G a m e   _ g a m e ;  
 	 p r i v a t e   i n t   _ s h o t s ;  
 	 p r i v a t e   i n t   _ h i t s ;  
  
 	 p r i v a t e   i n t   _ m i s s e s ;  
 	 / / /   < s u m m a r y >  
 	 / / /   R e t u r n s   t h e   g a m e   t h a t   t h e   p l a y e r   i s   p a r t   o f .  
 	 / / /   < / s u m m a r y >  
 	 / / /   < v a l u e > T h e   g a m e < / v a l u e >  
 	 / / /   < r e t u r n s > T h e   g a m e   t h a t   t h e   p l a y e r   i s   p l a y i n g < / r e t u r n s >  
 	 p u b l i c   B a t t l e S h i p s G a m e   G a m e   {  
 	 	 g e t   {   r e t u r n   _ g a m e ;   }  
 	 	 s e t   {   _ g a m e   =   v a l u e ;   }  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   S e t s   t h e   g r i d   o f   t h e   e n e m y   p l a y e r  
 	 / / /   < / s u m m a r y >  
 	 / / /   < v a l u e > T h e   e n e m y ' s   s e a   g r i d < / v a l u e >  
 	 p u b l i c   I S e a G r i d   E n e m y   {  
 	 	 s e t   {   _ e n e m y G r i d   =   v a l u e ;   }  
 	 }  
  
 	 p u b l i c   P l a y e r ( B a t t l e S h i p s G a m e   c o n t r o l l e r )  
 	 {  
 	 	 _ g a m e   =   c o n t r o l l e r ;  
  
 	 	 / / f o r   e a c h   s h i p   a d d   t h e   s h i p s   n a m e   s o   t h e   s e a g r i d   k n o w s   a b o u t   t h e m  
 	 	 f o r e a c h   ( S h i p N a m e   n a m e   i n   E n u m . G e t V a l u e s ( t y p e o f ( S h i p N a m e ) ) )   {  
 	 	 	 i f   ( n a m e   ! =   S h i p N a m e . N o n e )   {  
 	 	 	 	 _ S h i p s . A d d ( n a m e ,   n e w   S h i p ( n a m e ) ) ;  
 	 	 	 }  
 	 	 }  
  
 	 	 R a n d o m i z e D e p l o y m e n t ( ) ;  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   T h e   E n e m y G r i d   i s   a   I S e a G r i d   b e c a u s e   y o u   s h o u l d n ' t   b e   a l l o w e d   t o   s e e   t h e   e n e m i e s   s h i p s  
 	 / / /   < / s u m m a r y >  
 	 p u b l i c   I S e a G r i d   E n e m y G r i d   {  
 	 	 g e t   {   r e t u r n   _ e n e m y G r i d ;   }  
 	 	 s e t   {   _ e n e m y G r i d   =   v a l u e ;   }  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   T h e   P l a y e r G r i d   i s   j u s t   a   n o r m a l   S e a G r i d   w h e r e   t h e   p l a y e r s   s h i p s   c a n   b e   d e p l o y e d   a n d   s e e n  
 	 / / /   < / s u m m a r y >  
 	 p u b l i c   S e a G r i d   P l a y e r G r i d   {  
 	 	 g e t   {   r e t u r n   _ p l a y e r G r i d ;   }  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   R e a d y T o D e p l o y   r e t u r n s   t r u e   i f   a l l   s h i p s   a r e   d e p l o y e d  
 	 / / /   < / s u m m a r y >  
 	 p u b l i c   b o o l   R e a d y T o D e p l o y   {  
 	 	 g e t   {   r e t u r n   _ p l a y e r G r i d . A l l D e p l o y e d ;   }  
 	 }  
  
 	 p u b l i c   b o o l   I s D e s t r o y e d   {  
 / / C h e c k   i f   a l l   s h i p s   a r e   d e s t r o y e d . . .   - 1   f o r   t h e   n o n e   s h i p  
 	 	 g e t   {   r e t u r n   _ p l a y e r G r i d . S h i p s K i l l e d   = =   E n u m . G e t V a l u e s ( t y p e o f ( S h i p N a m e ) ) . L e n g t h   -   1 ;   }  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   R e t u r n s   t h e   P l a y e r ' s   s h i p   w i t h   t h e   g i v e n   n a m e .  
 	 / / /   < / s u m m a r y >  
 	 / / /   < p a r a m   n a m e = " n a m e " > t h e   n a m e   o f   t h e   s h i p   t o   r e t u r n < / p a r a m >  
 	 / / /   < v a l u e > T h e   s h i p < / v a l u e >  
 	 / / /   < r e t u r n s > T h e   s h i p   w i t h   t h e   i n d i c a t e d   n a m e < / r e t u r n s >  
 	 / / /   < r e m a r k s > T h e   n o n e   s h i p   r e t u r n s   n o t h i n g / n u l l < / r e m a r k s >  
 	 p u b l i c   S h i p   S h i p   {  
 	 	 g e t   {  
 	 	 	 i f   ( n a m e   = =   S h i p N a m e . N o n e )  
 	 	 	 	 r e t u r n   n u l l ;  
  
 	 	 	 r e t u r n   _ S h i p s . I t e m ( n a m e ) ;  
 	 	 }  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   T h e   n u m b e r   o f   s h o t s   t h e   p l a y e r   h a s   m a d e  
 	 / / /   < / s u m m a r y >  
 	 / / /   < v a l u e > s h o t s   t a k e n < / v a l u e >  
 	 / / /   < r e t u r n s > t e h   n u m b e r   o f   s h o t s   t a k e n < / r e t u r n s >  
 	 p u b l i c   i n t   S h o t s   {  
 	 	 g e t   {   r e t u r n   _ s h o t s ;   }  
 	 }  
  
 	 p u b l i c   i n t   H i t s   {  
 	 	 g e t   {   r e t u r n   _ h i t s ;   }  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   T o t a l   n u m b e r   o f   s h o t s   t h a t   m i s s e d  
 	 / / /   < / s u m m a r y >  
 	 / / /   < v a l u e > m i s s   c o u n t < / v a l u e >  
 	 / / /   < r e t u r n s > t h e   n u m b e r   o f   s h o t s   t h a t   h a v e   m i s s e d   s h i p s < / r e t u r n s >  
 	 p u b l i c   i n t   M i s s e d   {  
 	 	 g e t   {   r e t u r n   _ m i s s e s ;   }  
 	 }  
  
 	 p u b l i c   i n t   S c o r e   {  
 	 	 g e t   {  
 	 	 	 i f   ( I s D e s t r o y e d )   {  
 	 	 	 	 r e t u r n   0 ;  
 	 	 	 }   e l s e   {  
 	 	 	 	 r e t u r n   ( H i t s   *   1 2 )   -   S h o t s   -   ( P l a y e r G r i d . S h i p s K i l l e d   *   2 0 ) ;  
 	 	 	 }  
 	 	 }  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   M a k e s   i t   p o s s i b l e   t o   e n u m e r a t e   o v e r   t h e   s h i p s   t h e   p l a y e r  
 	 / / /   h a s .  
 	 / / /   < / s u m m a r y >  
 	 / / /   < r e t u r n s > A   S h i p   e n u m e r a t o r < / r e t u r n s >  
 	 p u b l i c   I E n u m e r a t o r < S h i p >   G e t S h i p E n u m e r a t o r ( )  
 	 {  
 	 	 S h i p [ ]   r e s u l t   =   n e w   S h i p [ _ S h i p s . V a l u e s . C o u n t   +   1 ] ;  
 	 	 _ S h i p s . V a l u e s . C o p y T o ( r e s u l t ,   0 ) ;  
 	 	 L i s t < S h i p >   l s t   =   n e w   L i s t < S h i p > ( ) ;  
 	 	 l s t . A d d R a n g e ( r e s u l t ) ;  
  
 	 	 r e t u r n   l s t . G e t E n u m e r a t o r ( ) ;  
 	 }  
 	 I E n u m e r a t o r < S h i p >   I E n u m e r a b l e < S h i p > . G e t E n u m e r a t o r ( )  
 	 {  
 	 	 r e t u r n   G e t S h i p E n u m e r a t o r ( ) ;  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   M a k e s   i t   p o s s i b l e   t o   e n u m e r a t e   o v e r   t h e   s h i p s   t h e   p l a y e r  
 	 / / /   h a s .  
 	 / / /   < / s u m m a r y >  
 	 / / /   < r e t u r n s > A   S h i p   e n u m e r a t o r < / r e t u r n s >  
 	 p u b l i c   I E n u m e r a t o r   G e t E n u m e r a t o r ( )  
 	 {  
 	 	 S h i p [ ]   r e s u l t   =   n e w   S h i p [ _ S h i p s . V a l u e s . C o u n t   +   1 ] ;  
 	 	 _ S h i p s . V a l u e s . C o p y T o ( r e s u l t ,   0 ) ;  
 	 	 L i s t < S h i p >   l s t   =   n e w   L i s t < S h i p > ( ) ;  
 	 	 l s t . A d d R a n g e ( r e s u l t ) ;  
  
 	 	 r e t u r n   l s t . G e t E n u m e r a t o r ( ) ;  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   V i t u a l   A t t a c k   a l l o w s   t h e   p l a y e r   t o   s h o o t  
 	 / / /   < / s u m m a r y >  
 	 p u b l i c   v i r t u a l   A t t a c k R e s u l t   A t t a c k ( )  
 	 {  
 	 	 / / h u m a n   d o e s   n o t h i n g   h e r e . . .  
 	 	 r e t u r n   n u l l ;  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   S h o o t   a t   a   g i v e n   r o w / c o l u m n  
 	 / / /   < / s u m m a r y >  
 	 / / /   < p a r a m   n a m e = " r o w " > t h e   r o w   t o   a t t a c k < / p a r a m >  
 	 / / /   < p a r a m   n a m e = " c o l " > t h e   c o l u m n   t o   a t t a c k < / p a r a m >  
 	 / / /   < r e t u r n s > t h e   r e s u l t   o f   t h e   a t t a c k < / r e t u r n s >  
 	 i n t e r n a l   A t t a c k R e s u l t   S h o o t ( i n t   r o w ,   i n t   c o l )  
 	 {  
 	 	 _ s h o t s   + =   1 ;  
 	 	 A t t a c k R e s u l t   r e s u l t   =   d e f a u l t ( A t t a c k R e s u l t ) ;  
 	 	 r e s u l t   =   E n e m y G r i d . H i t T i l e ( r o w ,   c o l ) ;  
  
 	 	 s w i t c h   ( r e s u l t . V a l u e )   {  
 	 	 	 c a s e   R e s u l t O f A t t a c k . D e s t r o y e d :  
 	 	 	 c a s e   R e s u l t O f A t t a c k . H i t :  
 	 	 	 	 _ h i t s   + =   1 ;  
 	 	 	 	 b r e a k ;  
 	 	 	 c a s e   R e s u l t O f A t t a c k . M i s s :  
 	 	 	 	 _ m i s s e s   + =   1 ;  
 	 	 	 	 b r e a k ;  
 	 	 }  
  
 	 	 r e t u r n   r e s u l t ;  
 	 }  
  
 	 p u b l i c   v i r t u a l   v o i d   R a n d o m i z e D e p l o y m e n t ( )  
 	 {  
 	 	 b o o l   p l a c e m e n t S u c c e s s f u l   =   f a l s e ;  
 	 	 D i r e c t i o n   h e a d i n g   =   d e f a u l t ( D i r e c t i o n ) ;  
  
 	 	 / / f o r   e a c h   s h i p   t o   d e p l o y   i n   s h i p i s t  
  
 	 	 f o r e a c h   ( S h i p N a m e   s h i p T o P l a c e   i n   E n u m . G e t V a l u e s ( t y p e o f ( S h i p N a m e ) ) )   {  
 	 	 	 i f   ( s h i p T o P l a c e   = =   S h i p N a m e . N o n e )  
 	 	 	 	 c o n t i n u e ;  
  
 	 	 	 p l a c e m e n t S u c c e s s f u l   =   f a l s e ;  
  
 	 	 	 / / g e n e r a t e   r a n d o m   p o s i t i o n   u n t i l   t h e   s h i p   c a n   b e   p l a c e d  
 	 	 	 d o   {  
 	 	 	 	 i n t   d i r   =   _ R a n d o m . N e x t ( 2 ) ;  
 	 	 	 	 i n t   x   =   _ R a n d o m . N e x t ( 0 ,   1 1 ) ;  
 	 	 	 	 i n t   y   =   _ R a n d o m . N e x t ( 0 ,   1 1 ) ;  
  
  
 	 	 	 	 i f   ( d i r   = =   0 )   {  
 	 	 	 	 	 h e a d i n g   =   D i r e c t i o n . U p D o w n ;  
 	 	 	 	 }   e l s e   {  
 	 	 	 	 	 h e a d i n g   =   D i r e c t i o n . L e f t R i g h t ;  
 	 	 	 	 }  
  
 	 	 	 	 / / t r y   t o   p l a c e   s h i p ,   i f   p o s i t i o n   u n p l a c e a b l e ,   g e n e r a t e   n e w   c o o r d i n a t e s  
 	 	 	 	 t r y   {  
 	 	 	 	 	 P l a y e r G r i d . M o v e S h i p ( x ,   y ,   s h i p T o P l a c e ,   h e a d i n g ) ;  
 	 	 	 	 	 p l a c e m e n t S u c c e s s f u l   =   t r u e ;  
 	 	 	 	 }   c a t c h   {  
 	 	 	 	 	 p l a c e m e n t S u c c e s s f u l   =   f a l s e ;  
 	 	 	 	 }  
 	 	 	 }   w h i l e   ( ! p l a c e m e n t S u c c e s s f u l ) ;  
 	 	 }  
 	 }  
 } } 
  
 / / = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =  
 / / S e r v i c e   p r o v i d e d   b y   T e l e r i k   ( w w w . t e l e r i k . c o m )  
 / / C o n v e r s i o n   p o w e r e d   b y   N R e f a c t o r y .  
 / / T w i t t e r :   @ t e l e r i k  
 / / F a c e b o o k :   f a c e b o o k . c o m / t e l e r i k  
 / / = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = 
