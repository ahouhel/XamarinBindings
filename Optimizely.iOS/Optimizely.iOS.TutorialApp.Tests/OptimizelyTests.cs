﻿using System;
using NUnit.Framework;
using Foundation;
using OptimizelyiOS;
using UIKit;

namespace Optimizely.iOS.Xamarin.TutorialApp.Test
{
    [TestFixture]
    public class OptimizelyTests
    {
        OptimizelyVariableKey variableKey = OptimizelyVariableKey.OptimizelyKeyWithKey ("key", "defaultVaue");
        OptimizelyCodeBlocksKey blocksKey = OptimizelyCodeBlocksKey.GetOptimizelyCodeBlocksKey ("key", new NSObject[] { });

        [Test]
        public void SharedInstance ()
        {
            try {
                OptimizelyiOS.Optimizely.SharedInstance ();
            } catch (Exception e) {
                Assert.Fail (e.Message);
            }
            Assert.Pass ();
        }

        [Test]
        public void StartOptimizelyWithAPIToken ()
        {
            try {
                OptimizelyiOS.Optimizely.StartOptimizelyWithAPIToken ("string apiToken", new NSDictionary ());
            } catch (Exception e) {
                Assert.Fail (e.Message);
            }
            Assert.Pass ();
        }

        [Test]
        public void StartOptimizelyWithAPITokenWithBlock ()
        {
            try {
                OptimizelyiOS.Optimizely.StartOptimizelyWithAPIToken ("string apiToken", new NSDictionary (), successBlock);
            } catch (Exception e) {
                Assert.Fail (e.Message);
            }
            Assert.Pass ();
        }

        [Test]
        public void SetValue ()
        {
            try {
                OptimizelyiOS.Optimizely.SetValue ("value", "value");
            } catch (Exception e) {
                Assert.Fail (e.Message);
            }
            Assert.Pass ();
        }

        [Test]
        public void HandleOpenURL ()
        {
            try {
                OptimizelyiOS.Optimizely.HandleOpenURL (new NSUrl (""));
            } catch (Exception e) {
                Assert.Fail (e.Message);
            }
            Assert.Pass ();
        }

        [Test]
        public void EnableEditor ()
        {
            try {
                OptimizelyiOS.Optimizely.EnableEditor ();
            } catch (Exception e) {
                Assert.Fail (e.Message);
            }
            Assert.Pass ();
        }

        [Test]
        public void DisableSwizzle ()
        {
            try {
                OptimizelyiOS.Optimizely.DisableSwizzle ();
            } catch (Exception e) {
                Assert.Fail (e.Message);
            }
            Assert.Pass ();
        }

        [Test]
        public void EnableGestureInAppStoreApp ()
        {
            try {
                OptimizelyiOS.Optimizely.EnableGestureInAppStoreApp ();
            } catch (Exception e) {
                Assert.Fail (e.Message);
            }
            Assert.Pass ();
        }

        [Test]
        public void Dispatch ()
        {
            try {
                OptimizelyiOS.Optimizely.Dispatch ();
            } catch (Exception e) {
                Assert.Fail (e.Message);
            }
            Assert.Pass ();
        }

        [Test]
        public void DispatchEvents ()
        {
            try {
                OptimizelyiOS.Optimizely.DispatchEvents ();
            } catch (Exception e) {
                Assert.Fail (e.Message);
            }
            Assert.Pass ();
        }

        [Test]
        public void FetchNewDataFile ()
        {
            try {
                OptimizelyiOS.Optimizely.FetchNewDataFile ();
            } catch (Exception e) {
                Assert.Fail (e.Message);
            }
            Assert.Pass ();
        }

        [Test]
        public void TrackEvent ()
        {
            try {
                OptimizelyiOS.Optimizely.TrackEvent ("event");
            } catch (Exception e) {
                Assert.Fail (e.Message);
            }
            Assert.Pass ();
        }

        [Test]
        public void TrackRevenue ()
        {
            try {
                OptimizelyiOS.Optimizely.TrackRevenue (1);
            } catch (Exception e) {
                Assert.Fail (e.Message);
            }
            Assert.Pass ();
        }

        [Test]
        public void RegisterCallbackForVariableWithKey ()
        {
            try {
                OptimizelyiOS.Optimizely.RegisterCallbackForVariableWithKey (variableKey, callback);
            } catch (Exception e) {
                Assert.Fail (e.Message);
            }
            Assert.Pass ();
        }

        [Test]
        public void RefreshExperiments ()
        {
            try {
                OptimizelyiOS.Optimizely.RefreshExperiments ();
            } catch (Exception e) {
                Assert.Fail (e.Message);
            }
            Assert.Pass ();
        }

        [Test]
        public void StringForKey ()
        {
            try {        
                OptimizelyiOS.Optimizely.StringForKey (variableKey);
            } catch (Exception e) {
                Assert.Fail (e.Message);
            }
            Assert.Pass ();
        }

        [Test]
        public void ColorForKey ()
        {
            try {
                OptimizelyiOS.Optimizely.ColorForKey (variableKey);
            } catch (Exception e) {
                Assert.Fail (e.Message);
            }
            Assert.Pass ();
        }

        [Test]
        public void NumberForKey ()
        {
            try {
                OptimizelyiOS.Optimizely.NumberForKey (variableKey);
            } catch (Exception e) {
                Assert.Fail (e.Message);
            }
            Assert.Pass ();
        }

        [Test]
        public void PointForKey ()
        {
            try {
                OptimizelyiOS.Optimizely.PointForKey (variableKey);
            } catch (Exception e) {
                Assert.Fail (e.Message);
            }
            Assert.Pass ();
        }

        [Test]
        public void SizeForKey ()
        {
            try {
                OptimizelyiOS.Optimizely.SizeForKey (variableKey);
            } catch (Exception e) {
                Assert.Fail (e.Message);
            }
            Assert.Pass ();
        }

        [Test]
        public void RectForKey ()
        {
            try {
                OptimizelyiOS.Optimizely.RectForKey (variableKey);
            } catch (Exception e) {
                Assert.Fail (e.Message);
            }
            Assert.Pass ();
        }

        [Test]
        public void BoolForKey ()
        {
            try {
                OptimizelyiOS.Optimizely.BoolForKey (variableKey);
            } catch (Exception e) {
                Assert.Fail (e.Message);
            }
            Assert.Pass ();
        }

        [Test]
        public void CodeBlocksWithKey ()
        {
            try {
                OptimizelyiOS.Optimizely.CodeBlocksWithKey (blocksKey, action, action);
            } catch (Exception e) {
                Assert.Fail (e.Message);
            }
            Assert.Pass ();
        }

        [Test]
        public void CodeBlocksWithKeyTwoBlocks ()
        {
            try {
                OptimizelyiOS.Optimizely.CodeBlocksWithKey (blocksKey, action, action, action);
            } catch (Exception e) {
                Assert.Fail (e.Message);
            }
            Assert.Pass ();
        }

        [Test]
        public void CodeBlocksWithKeyThreeBlocks ()
        {
            try {
                OptimizelyiOS.Optimizely.CodeBlocksWithKey (blocksKey, action, action, action, action);
            } catch (Exception e) {
                Assert.Fail (e.Message);
            }
            Assert.Pass ();
        }

        [Test]
        public void CodeBlocksWithKeyFourBlocks ()
        {
            try {
                OptimizelyiOS.Optimizely.CodeBlocksWithKey (blocksKey, action, action, action, action, action);
            } catch (Exception e) {
                Assert.Fail (e.Message);
            }
            Assert.Pass ();
        }

        [Test]
        public void PreregisterVariableKey ()
        {
            try {
                OptimizelyiOS.Optimizely.PreregisterVariableKey (variableKey);
            } catch (Exception e) {
                Assert.Fail (e.Message);
            }
            Assert.Pass ();
        }

        [Test]
        public void PreregisterBlockKey ()
        {
            try {        
                OptimizelyiOS.Optimizely.PreregisterBlockKey (blocksKey);
            } catch (Exception e) {
                Assert.Fail (e.Message);
            }
            Assert.Pass ();
        }

        [Test]
        public void IgnoreUIViewSubclassesWithNames ()
        {
            try {
                OptimizelyiOS.Optimizely.IgnoreUIViewSubclassesWithNames (new NSSet ());
            } catch (Exception e) {
                Assert.Fail (e.Message);
            }
            Assert.Pass ();
        }

        [Test]
        public void ActivateMixpanelIntegration ()
        {
            try {
                OptimizelyiOS.Optimizely.ActivateMixpanelIntegration ();
            } catch (Exception e) {
                Assert.Fail (e.Message);
            }
            Assert.Pass ();
        }

        [Test]
        public void CodeTest ()
        {
            try {
                OptimizelyiOS.Optimizely.SharedInstance ().CodeTest ("codeTestKey", new NSDictionary (), action);
            } catch (Exception e) {
                Assert.Fail (e.Message);
            }
            Assert.Pass ();
        }

        [Test]
        public void OptimizelyIdTest ()
        {
            try {
                const string testId = "test_id";
                var view = new UIView();

                view.SetOptimizelyId(testId);

                var optimizelyId = view.GetOptimizelyId();

                Assert.AreEqual(optimizelyId, testId, "Can get and set optimizelyId.");
            } catch (Exception e) {
                Assert.Fail (e.Message);
            }
        }

        OptimizelySuccessBlock successBlock = delegate {        
        };

        Action action = delegate {
        };

        Action<NSString, NSObject> callback = delegate {
        };
    }
}