 
 u s i n g   M i c r o s o f t . V i s u a l B a s i c ;  
 u s i n g   S y s t e m ;  
 u s i n g   S y s t e m . C o l l e c t i o n s ;  
 u s i n g   S y s t e m . C o l l e c t i o n s . G e n e r i c ;  
 u s i n g   S y s t e m . D a t a ;  
 u s i n g   S y s t e m . D i a g n o s t i c s ;  
 / / /   < s u m m a r y >  
 / / /   T i l e   k n o w s   i t s   l o c a t i o n   o n   t h e   g r i d ,   i f   i t   i s   a   s h i p   a n d   i f   i t   h a s   b e e n    
 / / /   s h o t   b e f o r e  
 / / /   < / s u m m a r y > namespace BattleShips
{ 

 p u b l i c   c l a s s   T i l e  
 {  
 	 	 / / t h e   r o w   v a l u e   o f   t h e   t i l e  
 	 p r i v a t e   r e a d o n l y   i n t   _ R o w V a l u e ;  
 	 	 / / t h e   c o l u m n   v a l u e   o f   t h e   t i l e  
 	 p r i v a t e   r e a d o n l y   i n t   _ C o l u m n V a l u e ;  
 	 	 / / t h e   s h i p   t h e   t i l e   b e l o n g s   t o  
 	 p r i v a t e   S h i p   _ S h i p   =   n u l l ;  
 	 	 / / t h e   t i l e   h a s   b e e n   s h o t   a t  
 	 p r i v a t e   b o o l   _ S h o t   =   f a l s e ;  
  
 	 / / /   < s u m m a r y >  
 	 / / /   H a s   t h e   t i l e   b e e n   s h o t ?  
 	 / / /   < / s u m m a r y >  
 	 / / /   < v a l u e > i n d i c a t e   i f   t h e   t i l e   h a s   b e e n   s h o t < / v a l u e >  
 	 / / /   < r e t u r n s > t r u e   i f   t h e   t i l e   w a s   s h o t < / r e t u r n s >  
 	 p u b l i c   b o o l   S h o t   {  
 	 	 g e t   {   r e t u r n   _ S h o t ;   }  
 	 	 s e t   {   _ S h o t   =   v a l u e ;   }  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   T h e   r o w   o f   t h e   t i l e   i n   t h e   g r i d  
 	 / / /   < / s u m m a r y >  
 	 / / /   < v a l u e > t h e   r o w   i n d e x   o f   t h e   t i l e   i n   t h e   g r i d < / v a l u e >  
 	 / / /   < r e t u r n s > t h e   r o w   i n d e x   o f   t h e   t i l e < / r e t u r n s >  
 	 p u b l i c   i n t   R o w   {  
 	 	 g e t   {   r e t u r n   _ R o w V a l u e ;   }  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   T h e   c o l u m n   o f   t h e   t i l e   i n   t h e   g r i d  
 	 / / /   < / s u m m a r y >  
 	 / / /   < v a l u e > t h e   c o l u m n   o f   t h e   t i l e   i n   t h e   g r i d < / v a l u e >  
 	 / / /   < r e t u r n s > t h e   c o l u m n   o f   t h e   t i l e   i n   t h e   g r i d < / r e t u r n s >  
 	 p u b l i c   i n t   C o l u m n   {  
 	 	 g e t   {   r e t u r n   _ C o l u m n V a l u e ;   }  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   S h i p   a l l o w s   f o r   a   t i l e   t o   c h e c k   i f   t h e r e   i s   s h i p   a n d   a d d   a   s h i p   t o   a   t i l e  
 	 / / /   < / s u m m a r y >  
 	 p u b l i c   S h i p   S h i p   {  
 	 	 g e t   {   r e t u r n   _ S h i p ;   }  
 	 	 s e t   {  
 	 	 	 i f   ( _ S h i p   = =   n u l l )   {  
 	 	 	 	 _ S h i p   =   v a l u e ;  
 	 	 	 	 i f   ( v a l u e   ! =   n u l l )   {  
 	 	 	 	 	 _ S h i p . A d d T i l e ( t h i s ) ;  
 	 	 	 	 }  
 	 	 	 }   e l s e   {  
 	 	 	 	 t h r o w   n e w   I n v a l i d O p e r a t i o n E x c e p t i o n ( " T h e r e   i s   a l r e a d y   a   s h i p   a t   [ "   +   R o w   +   " ,   "   +   C o l u m n   +   " ] " ) ;  
 	 	 	 }  
 	 	 }  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   T h e   t i l e   c o n s t r u c t o r   w i l l   k n o w   w h e r e   i t   i s   o n   t h e   g r i d ,   a n d   i s   i t s   a   s h i p  
 	 / / /   < / s u m m a r y >  
 	 / / /   < p a r a m   n a m e = " r o w " > t h e   r o w   o n   t h e   g r i d < / p a r a m >  
 	 / / /   < p a r a m   n a m e = " c o l " > t h e   c o l   o n   t h e   g r i d < / p a r a m >  
 	 / / /   < p a r a m   n a m e = " s h i p " > w h a t   s h i p   i t   i s < / p a r a m >  
 	 p u b l i c   T i l e ( i n t   r o w ,   i n t   c o l ,   S h i p   s h i p )  
 	 {  
 	 	 _ R o w V a l u e   =   r o w ;  
 	 	 _ C o l u m n V a l u e   =   c o l ;  
 	 	 _ S h i p   =   s h i p ;  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   C l e a r s h i p   w i l l   r e m o v e   t h e   s h i p   f r o m   t h e   t i l e  
 	 / / /   < / s u m m a r y >  
 	 p u b l i c   v o i d   C l e a r S h i p ( )  
 	 {  
 	 	 _ S h i p   =   n u l l ;  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   V i e w   i s   a b l e   t o   t e l l   t h e   g r i d   w h a t   t h e   t i l e   i s  
 	 / / /   < / s u m m a r y >  
 	 p u b l i c   T i l e V i e w   V i e w   {  
 	 	 g e t   {  
 	 	 	 / / i f   t h e r e   i s   n o   s h i p   i n   t h e   t i l e  
 	 	 	 i f   ( _ S h i p   = =   n u l l )   {  
 	 	 	 	 / / a n d   t h e   t i l e   h a s   b e e n   h i t  
  
 	 	 	 	 i f   ( _ S h o t )   {  
 	 	 	 	 	 r e t u r n   T i l e V i e w . M i s s ;  
 	 	 	 	 }   e l s e   {  
 	 	 	 	 	 / / a n d   t h e   t i l e   h a s n ' t   b e e n   h i t  
 	 	 	 	 	 r e t u r n   T i l e V i e w . S e a ;  
 	 	 	 	 }  
 	 	 	 }   e l s e   {  
 	 	 	 	 / / i f   t h e r e   i s   a   s h i p   a n d   i t   h a s   b e e n   h i t  
 	 	 	 	 i f   ( ( _ S h o t ) )   {  
 	 	 	 	 	 r e t u r n   T i l e V i e w . H i t ;  
 	 	 	 	 }   e l s e   {  
 	 	 	 	 	 / / i f   t h e r e   i s   a   s h i p   a n d   i t   h a s n ' t   b e e n   h i t  
 	 	 	 	 	 r e t u r n   T i l e V i e w . S h i p ;  
 	 	 	 	 }  
 	 	 	 }  
 	 	 }  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   S h o o t   a l l o w s   a   t i l e   t o   b e   s h o t   a t ,   a n d   i f   t h e   t i l e   h a s   b e e n   h i t   b e f o r e  
 	 / / /   i t   w i l l   g i v e   a n   e r r o r  
 	 / / /   < / s u m m a r y >  
 	 i n t e r n a l   v o i d   S h o o t ( )  
 	 {  
 	 	 i f   ( ( f a l s e   = =   S h o t ) )   {  
 	 	 	 S h o t   =   t r u e ;  
 	 	 	 i f   ( _ S h i p   ! =   n u l l )   {  
 	 	 	 	 _ S h i p . H i t ( ) ;  
 	 	 	 }  
 	 	 }   e l s e   {  
 	 	 	 t h r o w   n e w   A p p l i c a t i o n E x c e p t i o n ( " Y o u   h a v e   a l r e a d y   s h o t   t h i s   s q u a r e " ) ;  
 	 	 }  
 	 }  
 }  
} 
 / / = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =  
 / / S e r v i c e   p r o v i d e d   b y   T e l e r i k   ( w w w . t e l e r i k . c o m )  
 / / C o n v e r s i o n   p o w e r e d   b y   N R e f a c t o r y .  
 / / T w i t t e r :   @ t e l e r i k  
 / / F a c e b o o k :   f a c e b o o k . c o m / t e l e r i k  
 / / = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =  
  
 
