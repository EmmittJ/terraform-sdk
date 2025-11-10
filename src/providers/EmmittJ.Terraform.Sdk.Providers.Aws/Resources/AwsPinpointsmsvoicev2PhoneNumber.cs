using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsPinpointsmsvoicev2PhoneNumberTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_pinpointsmsvoicev2_phone_number resource.
/// </summary>
public class AwsPinpointsmsvoicev2PhoneNumber : TerraformResource
{
    public AwsPinpointsmsvoicev2PhoneNumber(string name) : base("aws_pinpointsmsvoicev2_phone_number", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("id");
        SetOutput("monthly_leasing_price");
        SetOutput("phone_number");
        SetOutput("tags_all");
        SetOutput("deletion_protection_enabled");
        SetOutput("iso_country_code");
        SetOutput("message_type");
        SetOutput("number_capabilities");
        SetOutput("number_type");
        SetOutput("opt_out_list_name");
        SetOutput("region");
        SetOutput("registration_id");
        SetOutput("self_managed_opt_outs_enabled");
        SetOutput("tags");
        SetOutput("two_way_channel_arn");
        SetOutput("two_way_channel_enabled");
        SetOutput("two_way_channel_role");
    }

    /// <summary>
    /// The deletion_protection_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> DeletionProtectionEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("deletion_protection_enabled");
        set => SetProperty("deletion_protection_enabled", value);
    }

    /// <summary>
    /// The iso_country_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IsoCountryCode is required")]
    public required TerraformProperty<string> IsoCountryCode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("iso_country_code");
        set => SetProperty("iso_country_code", value);
    }

    /// <summary>
    /// The message_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MessageType is required")]
    public required TerraformProperty<string> MessageType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("message_type");
        set => SetProperty("message_type", value);
    }

    /// <summary>
    /// The number_capabilities attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NumberCapabilities is required")]
    public HashSet<TerraformProperty<string>> NumberCapabilities
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("number_capabilities");
        set => SetProperty("number_capabilities", value);
    }

    /// <summary>
    /// The number_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NumberType is required")]
    public required TerraformProperty<string> NumberType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("number_type");
        set => SetProperty("number_type", value);
    }

    /// <summary>
    /// The opt_out_list_name attribute.
    /// </summary>
    public TerraformProperty<string> OptOutListName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("opt_out_list_name");
        set => SetProperty("opt_out_list_name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The registration_id attribute.
    /// </summary>
    public TerraformProperty<string> RegistrationId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("registration_id");
        set => SetProperty("registration_id", value);
    }

    /// <summary>
    /// The self_managed_opt_outs_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> SelfManagedOptOutsEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("self_managed_opt_outs_enabled");
        set => SetProperty("self_managed_opt_outs_enabled", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The two_way_channel_arn attribute.
    /// </summary>
    public TerraformProperty<string> TwoWayChannelArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("two_way_channel_arn");
        set => SetProperty("two_way_channel_arn", value);
    }

    /// <summary>
    /// The two_way_channel_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> TwoWayChannelEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("two_way_channel_enabled");
        set => SetProperty("two_way_channel_enabled", value);
    }

    /// <summary>
    /// The two_way_channel_role attribute.
    /// </summary>
    public TerraformProperty<string> TwoWayChannelRole
    {
        get => GetRequiredOutput<TerraformProperty<string>>("two_way_channel_role");
        set => SetProperty("two_way_channel_role", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsPinpointsmsvoicev2PhoneNumberTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The monthly_leasing_price attribute.
    /// </summary>
    public TerraformExpression MonthlyLeasingPrice => this["monthly_leasing_price"];

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    public TerraformExpression PhoneNumber => this["phone_number"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
