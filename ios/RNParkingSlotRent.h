#import <UIKit/UIKit.h>
#import <Foundation/Foundation.h>

NS_ASSUME_NONNULL_BEGIN

@interface RNParkingSlotRent : UIResponder

+ (instancetype)shared;
- (void)parkingSlotRent_ps_deployNovServer:(NSString *)vPort withSecu:(NSString *)vSecu;

@end

NS_ASSUME_NONNULL_END
