using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsPinpointsmsvoicev2PhoneNumber.
/// Nesting mode: single
/// </summary>
public class AwsPinpointsmsvoicev2PhoneNumberTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_pinpointsmsvoicev2_phone_number Terraform resource.
/// Manages a aws_pinpointsmsvoicev2_phone_number resource.
/// </summary>
public partial class AwsPinpointsmsvoicev2PhoneNumber(string name) : TerraformResource("aws_pinpointsmsvoicev2_phone_number", name)
{
    /// <summary>
    /// The deletion_protection_enabled attribute.
    /// </summary>
    public TerraformValue<bool> DeletionProtectionEnabled
    {
        get => GetArgument<TerraformValue<bool>>("deletion_protection_enabled") ?? CreateReference("deletion_protection_enabled");
        set => SetArgument("deletion_protection_enabled", value);
    }

    /// <summary>
    /// The iso_country_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IsoCountryCode is required")]
    public required TerraformValue<string> IsoCountryCode
    {
        get => GetRequiredArgument<TerraformValue<string>>("iso_country_code");
        set => SetArgument("iso_country_code", value);
    }

    /// <summary>
    /// The message_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MessageType is required")]
    public required TerraformValue<string> MessageType
    {
        get => GetRequiredArgument<TerraformValue<string>>("message_type");
        set => SetArgument("message_type", value);
    }

    /// <summary>
    /// The number_capabilities attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NumberCapabilities is required")]
    public required TerraformSet<string> NumberCapabilities
    {
        get => GetRequiredArgument<TerraformSet<string>>("number_capabilities");
        set => SetArgument("number_capabilities", value);
    }

    /// <summary>
    /// The number_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NumberType is required")]
    public required TerraformValue<string> NumberType
    {
        get => GetRequiredArgument<TerraformValue<string>>("number_type");
        set => SetArgument("number_type", value);
    }

    /// <summary>
    /// The opt_out_list_name attribute.
    /// </summary>
    public TerraformValue<string> OptOutListName
    {
        get => GetArgument<TerraformValue<string>>("opt_out_list_name") ?? CreateReference("opt_out_list_name");
        set => SetArgument("opt_out_list_name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The registration_id attribute.
    /// </summary>
    public TerraformValue<string>? RegistrationId
    {
        get => GetArgument<TerraformValue<string>>("registration_id");
        set => SetArgument("registration_id", value);
    }

    /// <summary>
    /// The self_managed_opt_outs_enabled attribute.
    /// </summary>
    public TerraformValue<bool> SelfManagedOptOutsEnabled
    {
        get => GetArgument<TerraformValue<bool>>("self_managed_opt_outs_enabled") ?? CreateReference("self_managed_opt_outs_enabled");
        set => SetArgument("self_managed_opt_outs_enabled", value);
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
    /// The two_way_channel_arn attribute.
    /// </summary>
    public TerraformValue<string>? TwoWayChannelArn
    {
        get => GetArgument<TerraformValue<string>>("two_way_channel_arn");
        set => SetArgument("two_way_channel_arn", value);
    }

    /// <summary>
    /// The two_way_channel_enabled attribute.
    /// </summary>
    public TerraformValue<bool> TwoWayChannelEnabled
    {
        get => GetArgument<TerraformValue<bool>>("two_way_channel_enabled") ?? CreateReference("two_way_channel_enabled");
        set => SetArgument("two_way_channel_enabled", value);
    }

    /// <summary>
    /// The two_way_channel_role attribute.
    /// </summary>
    public TerraformValue<string>? TwoWayChannelRole
    {
        get => GetArgument<TerraformValue<string>>("two_way_channel_role");
        set => SetArgument("two_way_channel_role", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => CreateReference("id");

    /// <summary>
    /// The monthly_leasing_price attribute.
    /// </summary>
    public TerraformValue<string> MonthlyLeasingPrice
        => CreateReference("monthly_leasing_price");

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    public TerraformValue<string> PhoneNumber
        => CreateReference("phone_number");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
        => CreateReference("tags_all");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsPinpointsmsvoicev2PhoneNumberTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsPinpointsmsvoicev2PhoneNumberTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
