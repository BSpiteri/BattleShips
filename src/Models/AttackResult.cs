 
  
 u s i n g   M i c r o s o f t . V i s u a l B a s i c ;  
 u s i n g   S y s t e m ;  
 u s i n g   S y s t e m . C o l l e c t i o n s ;  
 u s i n g   S y s t e m . C o l l e c t i o n s . G e n e r i c ;  
 u s i n g   S y s t e m . D a t a ;  
 u s i n g   S y s t e m . D i a g n o s t i c s ;  
 / / /   < s u m m a r y >  
 / / /   A t t a c k R e s u l t   g i v e s   t h e   r e s u l t   a f t e r   a   s h o t   h a s   b e e n   m a d e .  
 / / /   < / s u m m a r y >  namespace BattleShips
{
 p u b l i c   c l a s s   A t t a c k R e s u l t  
 {  
 	 p r i v a t e   R e s u l t O f A t t a c k   _ V a l u e ;  
 	 p r i v a t e   S h i p   _ S h i p ;  
 	 p r i v a t e   s t r i n g   _ T e x t ;  
 	 p r i v a t e   i n t   _ R o w ;  
  
 	 p r i v a t e   i n t   _ C o l u m n ;  
 	 / / /   < s u m m a r y >  
 	 / / /   T h e   r e s u l t   o f   t h e   a t t a c k  
 	 / / /   < / s u m m a r y >  
 	 / / /   < v a l u e > T h e   r e s u l t   o f   t h e   a t t a c k < / v a l u e >  
 	 / / /   < r e t u r n s > T h e   r e s u l t   o f   t h e   a t t a c k < / r e t u r n s >  
 	 p u b l i c   R e s u l t O f A t t a c k   V a l u e   {  
 	 	 g e t   {   r e t u r n   _ V a l u e ;   }  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   T h e   s h i p ,   i f   a n y ,   i n v o l v e d   i n   t h i s   r e s u l t  
 	 / / /   < / s u m m a r y >  
 	 / / /   < v a l u e > T h e   s h i p ,   i f   a n y ,   i n v o l v e d   i n   t h i s   r e s u l t < / v a l u e >  
 	 / / /   < r e t u r n s > T h e   s h i p ,   i f   a n y ,   i n v o l v e d   i n   t h i s   r e s u l t < / r e t u r n s >  
 	 p u b l i c   S h i p   S h i p   {  
 	 	 g e t   {   r e t u r n   _ S h i p ;   }  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   A   t e x t u a l   d e s c r i p t i o n   o f   t h e   r e s u l t .  
 	 / / /   < / s u m m a r y >  
 	 / / /   < v a l u e > A   t e x t u a l   d e s c r i p t i o n   o f   t h e   r e s u l t . < / v a l u e >  
 	 / / /   < r e t u r n s > A   t e x t u a l   d e s c r i p t i o n   o f   t h e   r e s u l t . < / r e t u r n s >  
 	 / / /   < r e m a r k s > A   t e x t u a l   d e s c r i p t i o n   o f   t h e   r e s u l t . < / r e m a r k s >  
 	 p u b l i c   s t r i n g   T e x t   {  
 	 	 g e t   {   r e t u r n   _ T e x t ;   }  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   T h e   r o w   w h e r e   t h e   a t t a c k   o c c u r r e d  
 	 / / /   < / s u m m a r y >  
 	 p u b l i c   i n t   R o w   {  
 	 	 g e t   {   r e t u r n   _ R o w ;   }  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   T h e   c o l u m n   w h e r e   t h e   a t t a c k   o c c u r r e d  
 	 / / /   < / s u m m a r y >  
 	 p u b l i c   i n t   C o l u m n   {  
 	 	 g e t   {   r e t u r n   _ C o l u m n ;   }  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   S e t   t h e   _ V a l u e   t o   t h e   P o s s i b l e A t t a c k   v a l u e  
 	 / / /   < / s u m m a r y >  
 	 / / /   < p a r a m   n a m e = " v a l u e " > e i t h e r   h i t ,   m i s s ,   d e s t r o y e d ,   s h o t a l r e a d y < / p a r a m >  
 	 p u b l i c   A t t a c k R e s u l t ( R e s u l t O f A t t a c k   v a l u e ,   s t r i n g   t e x t ,   i n t   r o w ,   i n t   c o l u m n )  
 	 {  
 	 	 _ V a l u e   =   v a l u e ;  
 	 	 _ T e x t   =   t e x t ;  
 	 	 _ S h i p   =   n u l l ;  
 	 	 _ R o w   =   r o w ;  
 	 	 _ C o l u m n   =   c o l u m n ;  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   S e t   t h e   _ V a l u e   t o   t h e   P o s s i b l e A t t a c k   v a l u e ,   a n d   t h e   _ S h i p   t o   t h e   s h i p  
 	 / / /   < / s u m m a r y >  
 	 / / /   < p a r a m   n a m e = " v a l u e " > e i t h e r   h i t ,   m i s s ,   d e s t r o y e d ,   s h o t a l r e a d y < / p a r a m >  
 	 / / /   < p a r a m   n a m e = " s h i p " > t h e   s h i p   i n f o r m a t i o n < / p a r a m >  
 	 p u b l i c   A t t a c k R e s u l t ( R e s u l t O f A t t a c k   v a l u e ,   S h i p   s h i p ,   s t r i n g   t e x t ,   i n t   r o w ,   i n t   c o l u m n )   :   t h i s ( v a l u e ,   t e x t ,   r o w ,   c o l u m n )  
 	 {  
 	 	 _ S h i p   =   s h i p ;  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   D i s p l a y s   t h e   t e x t u a l   i n f o r m a t i o n   a b o u t   t h e   a t t a c k  
 	 / / /   < / s u m m a r y >  
 	 / / /   < r e t u r n s > T h e   t e x t u a l   i n f o r m a t i o n   a b o u t   t h e   a t t a c k < / r e t u r n s >  
 	 p u b l i c   o v e r r i d e   s t r i n g   T o S t r i n g ( )  
 	 {  
 	 	 i f   ( _ S h i p   = =   n u l l )   {  
 	 	 	 r e t u r n   T e x t ;  
 	 	 }  
  
 	 	 r e t u r n   T e x t   +   "   "   +   _ S h i p . N a m e ;  
 	 }  
 }  }
  
 / / = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =  
 / / S e r v i c e   p r o v i d e d   b y   T e l e r i k   ( w w w . t e l e r i k . c o m )  
 / / C o n v e r s i o n   p o w e r e d   b y   N R e f a c t o r y .  
 / / T w i t t e r :   @ t e l e r i k  
 / / F a c e b o o k :   f a c e b o o k . c o m / t e l e r i k  
 / / = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =  
 
