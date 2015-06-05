using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Metadata.Builders;
using Microsoft.Data.Entity.Relational.Migrations.Infrastructure;
using MyCodeFiratAPNET5.Models;

namespace MyCodeFiratAPNET5.Migrations
{
    [ContextType(typeof(ClassRoomContext))]
    partial class NewCustomer
    {
        public override string Id
        {
            get { return "20150529092642_NewCustomer"; }
        }
        
        public override string ProductVersion
        {
            get { return "7.0.0-beta4-12943"; }
        }
        
        public override IModel Target
        {
            get
            {
                var builder = new BasicModelBuilder()
                    .Annotation("SqlServer:ValueGeneration", "Sequence");
                
                builder.Entity("MyCodeFiratAPNET5.Models.ClassRoom", b =>
                    {
                        b.Property<int>("BuildingId")
                            .Annotation("OriginalValueIndex", 0);
                        b.Property<int>("ClassFloor")
                            .Annotation("OriginalValueIndex", 1);
                        b.Property<string>("ClassRoomId")
                            .Annotation("OriginalValueIndex", 2);
                        b.Property<string>("ClassRoomName")
                            .Annotation("OriginalValueIndex", 3);
                        b.Property<int>("NumOfPeoples")
                            .Annotation("OriginalValueIndex", 4);
                        b.Property<int>("id")
                            .GenerateValueOnAdd()
                            .Annotation("OriginalValueIndex", 5)
                            .Annotation("SqlServer:ValueGeneration", "Default");
                        b.Key("id");
                    });
                
                return builder.Model;
            }
        }
    }
}
