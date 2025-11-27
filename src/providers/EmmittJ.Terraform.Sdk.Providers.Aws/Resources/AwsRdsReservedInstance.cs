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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
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
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The instance_count attribute.
    /// </summary>
    public TerraformValue<double>? InstanceCount
    {
        get => new TerraformReference<double>(this, "instance_count");
        set => SetArgument("instance_count", value);
    }

    /// <summary>
    /// The offering_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OfferingId is required")]
    public required TerraformValue<string> OfferingId
    {
        get => new TerraformReference<string>(this, "offering_id");
        set => SetArgument("offering_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The reservation_id attribute.
    /// </summary>
    public TerraformValue<string>? ReservationId
    {
        get => new TerraformReference<string>(this, "reservation_id");
        set => SetArgument("reservation_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The currency_code attribute.
    /// </summary>
    public TerraformValue<string> CurrencyCode
    {
        get => new TerraformReference<string>(this, "currency_code");
    }

    /// <summary>
    /// The db_instance_class attribute.
    /// </summary>
    public TerraformValue<string> DbInstanceClass
    {
        get => new TerraformReference<string>(this, "db_instance_class");
    }

    /// <summary>
    /// The duration attribute.
    /// </summary>
    public TerraformValue<double> Duration
    {
        get => new TerraformReference<double>(this, "duration");
    }

    /// <summary>
    /// The fixed_price attribute.
    /// </summary>
    public TerraformValue<double> FixedPrice
    {
        get => new TerraformReference<double>(this, "fixed_price");
    }

    /// <summary>
    /// The lease_id attribute.
    /// </summary>
    public TerraformValue<string> LeaseId
    {
        get => new TerraformReference<string>(this, "lease_id");
    }

    /// <summary>
    /// The multi_az attribute.
    /// </summary>
    public TerraformValue<bool> MultiAz
    {
        get => new TerraformReference<bool>(this, "multi_az");
    }

    /// <summary>
    /// The offering_type attribute.
    /// </summary>
    public TerraformValue<string> OfferingType
    {
        get => new TerraformReference<string>(this, "offering_type");
    }

    /// <summary>
    /// The product_description attribute.
    /// </summary>
    public TerraformValue<string> ProductDescription
    {
        get => new TerraformReference<string>(this, "product_description");
    }

    /// <summary>
    /// The recurring_charges attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> RecurringCharges
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "recurring_charges").ResolveNodes(ctx));
    }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    public TerraformValue<string> StartTime
    {
        get => new TerraformReference<string>(this, "start_time");
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

    /// <summary>
    /// The usage_price attribute.
    /// </summary>
    public TerraformValue<double> UsagePrice
    {
        get => new TerraformReference<double>(this, "usage_price");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsRdsReservedInstanceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsRdsReservedInstanceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
