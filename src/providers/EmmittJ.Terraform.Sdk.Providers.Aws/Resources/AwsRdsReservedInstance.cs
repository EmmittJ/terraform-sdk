using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsRdsReservedInstance.
/// Nesting mode: single
/// </summary>
public class AwsRdsReservedInstanceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_rds_reserved_instance Terraform resource.
/// Manages a aws_rds_reserved_instance resource.
/// </summary>
public partial class AwsRdsReservedInstance(string name) : TerraformResource("aws_rds_reserved_instance", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The instance_count attribute.
    /// </summary>
    public TerraformValue<double>? InstanceCount
    {
        get => GetArgument<TerraformValue<double>>("instance_count");
        set => SetArgument("instance_count", value);
    }

    /// <summary>
    /// The offering_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OfferingId is required")]
    public required TerraformValue<string> OfferingId
    {
        get => GetArgument<TerraformValue<string>>("offering_id");
        set => SetArgument("offering_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The reservation_id attribute.
    /// </summary>
    public TerraformValue<string>? ReservationId
    {
        get => GetArgument<TerraformValue<string>>("reservation_id");
        set => SetArgument("reservation_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The currency_code attribute.
    /// </summary>
    public TerraformValue<string> CurrencyCode
        => AsReference("currency_code");

    /// <summary>
    /// The db_instance_class attribute.
    /// </summary>
    public TerraformValue<string> DbInstanceClass
        => AsReference("db_instance_class");

    /// <summary>
    /// The duration attribute.
    /// </summary>
    public TerraformValue<double> Duration
        => AsReference("duration");

    /// <summary>
    /// The fixed_price attribute.
    /// </summary>
    public TerraformValue<double> FixedPrice
        => AsReference("fixed_price");

    /// <summary>
    /// The lease_id attribute.
    /// </summary>
    public TerraformValue<string> LeaseId
        => AsReference("lease_id");

    /// <summary>
    /// The multi_az attribute.
    /// </summary>
    public TerraformValue<bool> MultiAz
        => AsReference("multi_az");

    /// <summary>
    /// The offering_type attribute.
    /// </summary>
    public TerraformValue<string> OfferingType
        => AsReference("offering_type");

    /// <summary>
    /// The product_description attribute.
    /// </summary>
    public TerraformValue<string> ProductDescription
        => AsReference("product_description");

    /// <summary>
    /// The recurring_charges attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> RecurringCharges
        => AsReference("recurring_charges");

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    public TerraformValue<string> StartTime
        => AsReference("start_time");

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// The usage_price attribute.
    /// </summary>
    public TerraformValue<double> UsagePrice
        => AsReference("usage_price");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsRdsReservedInstanceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsRdsReservedInstanceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
