# DropShadowCrashDemo

I  found this bug when using [MS Community Toolkit](https://github.com/CommunityToolkit/WindowsCommunityToolkit)'s AttachedCardShadow in a UWP and I wanted to share it in case someone have any insight on that.
The issue is when attaching the card shadow to a listview item on mouse over, after removing that item and then adding a new one the app crashes or doesn't render the shadow in the new item.

To make this issue in action:
1. Run the app and make sure all the items loaded shows a drop shadow effect when moving the mouse over them.
2. Click on "Hit me", that will remove the first item and add a new one at the beggining.
3. Now move the mouse over that new item.

The results varies from a crash to the new item not rendering the card shadow at all.

**Note:** It's important to note that the ListView used in this demo has an empty `TransitionCollection`, that's because I need the items do not have animation on adding or removing, if you remove the empty `TransitionCollection` the drop shadow behaves as expected.
