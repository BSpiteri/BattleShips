 
 u s i n g   M i c r o s o f t . V i s u a l B a s i c ;  
 u s i n g   S y s t e m ;  
 u s i n g   S y s t e m . C o l l e c t i o n s ;  
 u s i n g   S y s t e m . C o l l e c t i o n s . G e n e r i c ;  
 u s i n g   S y s t e m . D a t a ;  
 u s i n g   S y s t e m . D i a g n o s t i c s ;  
 / / /   < s u m m a r y >  
 / / /   A   S h i p   h a s   a l l   t h e   d e t a i l s   a b o u t   i t s e l f .   F o r   e x a m p l e   t h e   s h i p n a m e ,  
 / / /   s i z e ,   n u m b e r   o f   h i t s   t a k e n   a n d   t h e   l o c a t i o n .   I t s   a b l e   t o   a d d   t i l e s ,  
 / / /   r e m o v e ,   h i t s   t a k e n   a n d   i f   i t s   d e p l o y e d   a n d   d e s t r o y e d .  
 / / /   < / s u m m a r y >  
 / / /   < r e m a r k s >  
 / / /   D e p l o y m e n t   i n f o r m a t i o n   i s   s u p p l i e d   t o   a l l o w   s h i p s   t o   b e   d r a w n .  
 / / /   < / r e m a r k s > namespace BattleShip{ p u b l i c   c l a s s   S h i p  
 {  
 	 p r i v a t e   S h i p N a m e   _ s h i p N a m e ;  
 	 p r i v a t e   i n t   _ s i z e O f S h i p ;  
 	 p r i v a t e   i n t   _ h i t s T a k e n   =   0 ;  
 	 p r i v a t e   L i s t < T i l e >   _ t i l e s ;  
 	 p r i v a t e   i n t   _ r o w ;  
 	 p r i v a t e   i n t   _ c o l ;  
  
 	 p r i v a t e   D i r e c t i o n   _ d i r e c t i o n ;  
 	 / / /   < s u m m a r y >  
 	 / / /   T h e   t y p e   o f   s h i p  
 	 / / /   < / s u m m a r y >  
 	 / / /   < v a l u e > T h e   t y p e   o f   s h i p < / v a l u e >  
 	 / / /   < r e t u r n s > T h e   t y p e   o f   s h i p < / r e t u r n s >  
 	 p u b l i c   s t r i n g   N a m e   {  
 	 	 g e t   {  
 	 	 	 i f   ( _ s h i p N a m e   = =   S h i p N a m e . A i r c r a f t C a r r i e r )   {  
 	 	 	 	 r e t u r n   " A i r c r a f t   C a r r i e r " ;  
 	 	 	 }  
  
 	 	 	 r e t u r n   _ s h i p N a m e . T o S t r i n g ( ) ;  
 	 	 }  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   T h e   n u m b e r   o f   c e l l s   t h a t   t h i s   s h i p   o c c u p i e s .  
 	 / / /   < / s u m m a r y >  
 	 / / /   < v a l u e > T h e   n u m b e r   o f   h i t s   t h e   s h i p   c a n   t a k e < / v a l u e >  
 	 / / /   < r e t u r n s > T h e   n u m b e r   o f   h i t s   t h e   s h i p   c a n   t a k e < / r e t u r n s >  
 	 p u b l i c   i n t   S i z e   {  
 	 	 g e t   {   r e t u r n   _ s i z e O f S h i p ;   }  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   T h e   n u m b e r   o f   h i t s   t h a t   t h e   s h i p   h a s   t a k e n .  
 	 / / /   < / s u m m a r y >  
 	 / / /   < v a l u e > T h e   n u m b e r   o f   h i t s   t h e   s h i p   h a s   t a k e n . < / v a l u e >  
 	 / / /   < r e t u r n s > T h e   n u m b e r   o f   h i t s   t h e   s h i p   h a s   t a k e n < / r e t u r n s >  
 	 / / /   < r e m a r k s > W h e n   t h i s   e q u a l s   S i z e   t h e   s h i p   i s   s u n k < / r e m a r k s >  
 	 p u b l i c   i n t   H i t s   {  
 	 	 g e t   {   r e t u r n   _ h i t s T a k e n ;   }  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   T h e   r o w   l o c a t i o n   o f   t h e   s h i p  
 	 / / /   < / s u m m a r y >  
 	 / / /   < v a l u e > T h e   t o p m o s t   l o c a t i o n   o f   t h e   s h i p < / v a l u e >  
 	 / / /   < r e t u r n s > t h e   r o w   o f   t h e   s h i p < / r e t u r n s >  
 	 p u b l i c   i n t   R o w   {  
 	 	 g e t   {   r e t u r n   _ r o w ;   }  
 	 }  
  
 	 p u b l i c   i n t   C o l u m n   {  
 	 	 g e t   {   r e t u r n   _ c o l ;   }  
 	 }  
  
 	 p u b l i c   D i r e c t i o n   D i r e c t i o n   {  
 	 	 g e t   {   r e t u r n   _ d i r e c t i o n ;   }  
 	 }  
  
 	 p u b l i c   S h i p ( S h i p N a m e   s h i p )  
 	 {  
 	 	 _ s h i p N a m e   =   s h i p ;  
 	 	 _ t i l e s   =   n e w   L i s t < T i l e > ( ) ;  
  
 	 	 / / g e t s   t h e   s h i p   s i z e   f r o m   t h e   e n u m a r a t o r  
 	 	 _ s i z e O f S h i p   =   _ s h i p N a m e ;  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   A d d   t i l e   a d d s   t h e   s h i p   t i l e  
 	 / / /   < / s u m m a r y >  
 	 / / /   < p a r a m   n a m e = " t i l e " > o n e   o f   t h e   t i l e s   t h e   s h i p   i s   o n < / p a r a m >  
 	 p u b l i c   v o i d   A d d T i l e ( T i l e   t i l e )  
 	 {  
 	 	 _ t i l e s . A d d ( t i l e ) ;  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   R e m o v e   c l e a r s   t h e   t i l e   b a c k   t o   a   s e a   t i l e  
 	 / / /   < / s u m m a r y >  
 	 p u b l i c   v o i d   R e m o v e ( )  
 	 {  
 	 	 f o r e a c h   ( T i l e   t i l e   i n   _ t i l e s )   {  
 	 	 	 t i l e . C l e a r S h i p ( ) ;  
 	 	 }  
 	 	 _ t i l e s . C l e a r ( ) ;  
 	 }  
  
 	 p u b l i c   v o i d   H i t ( )  
 	 {  
 	 	 _ h i t s T a k e n   =   _ h i t s T a k e n   +   1 ;  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   I s D e p l o y e d   r e t u r n s   i f   t h e   s h i p s   i s   d e p l o y e d ,   i f   i t s   d e p l y e d   i t   h a s   m o r e   t h a n  
 	 / / /   0   t i l e s  
 	 / / /   < / s u m m a r y >  
 	 p u b l i c   b o o l   I s D e p l o y e d   {  
 	 	 g e t   {   r e t u r n   _ t i l e s . C o u n t   >   0 ;   }  
 	 }  
  
 	 p u b l i c   b o o l   I s D e s t r o y e d   {  
 	 	 g e t   {   r e t u r n   H i t s   = =   S i z e ;   }  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   R e c o r d   t h a t   t h e   s h i p   i s   n o w   d e p l o y e d .  
 	 / / /   < / s u m m a r y >  
 	 / / /   < p a r a m   n a m e = " d i r e c t i o n " > < / p a r a m >  
 	 / / /   < p a r a m   n a m e = " r o w " > < / p a r a m >  
 	 / / /   < p a r a m   n a m e = " c o l " > < / p a r a m >  
 	 i n t e r n a l   v o i d   D e p l o y e d ( D i r e c t i o n   d i r e c t i o n ,   i n t   r o w ,   i n t   c o l )  
 	 {  
 	 	 _ r o w   =   r o w ;  
 	 	 _ c o l   =   c o l ;  
 	 	 _ d i r e c t i o n   =   d i r e c t i o n ;  
 	 }  
 } } 
  
 / / = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =  
 / / S e r v i c e   p r o v i d e d   b y   T e l e r i k   ( w w w . t e l e r i k . c o m )  
 / / C o n v e r s i o n   p o w e r e d   b y   N R e f a c t o r y .  
 / / T w i t t e r :   @ t e l e r i k  
 / / F a c e b o o k :   f a c e b o o k . c o m / t e l e r i k  
 / / = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =  
  
 
