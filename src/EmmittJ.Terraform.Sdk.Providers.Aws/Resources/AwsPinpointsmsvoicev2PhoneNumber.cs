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
    public TerraformLiteralProperty<bool>? DeletionProtectionEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("deletion_protection_enabled");
        set => this.WithProperty("deletion_protection_enabled", value);
    }

    /// <summary>
    /// The iso_country_code attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? IsoCountryCode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("iso_country_code");
        set => this.WithProperty("iso_country_code", value);
    }

    /// <summary>
    /// The message_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? MessageType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("message_type");
        set => this.WithProperty("message_type", value);
    }

    /// <summary>
    /// The number_capabilities attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? NumberCapabilities
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("number_capabilities");
        set => this.WithProperty("number_capabilities", value);
    }

    /// <summary>
    /// The number_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? NumberType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("number_type");
        set => this.WithProperty("number_type", value);
    }

    /// <summary>
    /// The opt_out_list_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? OptOutListName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("opt_out_list_name");
        set => this.WithProperty("opt_out_list_name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The registration_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RegistrationId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("registration_id");
        set => this.WithProperty("registration_id", value);
    }

    /// <summary>
    /// The self_managed_opt_outs_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? SelfManagedOptOutsEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("self_managed_opt_outs_enabled");
        set => this.WithProperty("self_managed_opt_outs_enabled", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The two_way_channel_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TwoWayChannelArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("two_way_channel_arn");
        set => this.WithProperty("two_way_channel_arn", value);
    }

    /// <summary>
    /// The two_way_channel_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? TwoWayChannelEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("two_way_channel_enabled");
        set => this.WithProperty("two_way_channel_enabled", value);
    }

    /// <summary>
    /// The two_way_channel_role attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TwoWayChannelRole
    {
        get => GetProperty<TerraformLiteralProperty<string>>("two_way_channel_role");
        set => this.WithProperty("two_way_channel_role", value);
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
