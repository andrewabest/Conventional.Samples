CREATE TABLE [dbo].[Attendee](
	[Id] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_Attendee] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE [dbo].[AttendeeBookings](
	[Id] [uniqueidentifier] NOT NULL,
	[AttendeeId] [uniqueidentifier] NOT NULL,
	[BookingId] [uniqueidentifier] NOT NULL
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[AttendeeBookings]  WITH CHECK ADD  CONSTRAINT [FK_AttendeeBookings_Attendee] FOREIGN KEY([AttendeeId])
REFERENCES [dbo].[Attendee] ([Id])
GO

ALTER TABLE [dbo].[AttendeeBookings] CHECK CONSTRAINT [FK_AttendeeBookings_Attendee]
GO

ALTER TABLE [dbo].[AttendeeBookings]  WITH CHECK ADD  CONSTRAINT [FK_AttendeeBookings_Booking] FOREIGN KEY([BookingId])
REFERENCES [dbo].[Booking] ([Id])
GO

ALTER TABLE [dbo].[AttendeeBookings] CHECK CONSTRAINT [FK_AttendeeBookings_Booking]
GO