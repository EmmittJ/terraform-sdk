using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
        this.DeclareOutput("arn");
        this.DeclareOutput("id");
        this.DeclareOutput("monthly_leasing_price");
        this.DeclareOutput("phone_number");
        this.DeclareOutput("tags_all");
    }

    /// <summary>
    /// The deletion_protection_enabled attribute.
    /// </summary>
    public bool? DeletionProtectionEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("deletion_protection_enabled")?.Value;
        set => this.WithProperty("deletion_protection_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The iso_country_code attribute.
    /// </summary>
    public string? IsoCountryCode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("iso_country_code")?.Value;
        set => this.WithProperty("iso_country_code", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The message_type attribute.
    /// </summary>
    public string? MessageType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("message_type")?.Value;
        set => this.WithProperty("message_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The number_capabilities attribute.
    /// </summary>
    public HashSet<string>? NumberCapabilities
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("number_capabilities")?.Value;
        set => this.WithProperty("number_capabilities", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The number_type attribute.
    /// </summary>
    public string? NumberType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("number_type")?.Value;
        set => this.WithProperty("number_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The opt_out_list_name attribute.
    /// </summary>
    public string? OptOutListName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("opt_out_list_name")?.Value;
        set => this.WithProperty("opt_out_list_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The registration_id attribute.
    /// </summary>
    public string? RegistrationId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("registration_id")?.Value;
        set => this.WithProperty("registration_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The self_managed_opt_outs_enabled attribute.
    /// </summary>
    public bool? SelfManagedOptOutsEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("self_managed_opt_outs_enabled")?.Value;
        set => this.WithProperty("self_managed_opt_outs_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The two_way_channel_arn attribute.
    /// </summary>
    public string? TwoWayChannelArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("two_way_channel_arn")?.Value;
        set => this.WithProperty("two_way_channel_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The two_way_channel_enabled attribute.
    /// </summary>
    public bool? TwoWayChannelEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("two_way_channel_enabled")?.Value;
        set => this.WithProperty("two_way_channel_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The two_way_channel_role attribute.
    /// </summary>
    public string? TwoWayChannelRole
    {
        get => GetProperty<TerraformLiteralProperty<string>>("two_way_channel_role")?.Value;
        set => this.WithProperty("two_way_channel_role", value == null ? null : new TerraformLiteralProperty<string>(value));
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
