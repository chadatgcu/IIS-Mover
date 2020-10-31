IIS Mover
Current Version 1.0.3
Chad Weirick

Welcome!

This program is designed to facilitate common tasks that occur when moving IIs instances.  For example, many developers have a dev environment which would in turn be pushed to a testing environment when the developers have test-ready code.  From there, a test environment could be moved to a customer training/certification environment if it is deemed stable and complete.  From there a customer might request that it be sent to production when they are ready.

The core functions are:

- App Pool start/stop
- File compressing - a common backup task
- File copying - to facilitate moving instances physically
- Forcing a notice/wait notification for tasks outside the scope of IIS Mover
- Making API calls - this could be used to rebuild metadata/etc.

Included in this release is the source code, and a documentation folder with an admin guide and an end user guide.