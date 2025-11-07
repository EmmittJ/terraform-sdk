using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ivschat_room resource.
/// </summary>
public class AwsIvschatRoom : TerraformResource
{
    public AwsIvschatRoom(string name) : base("aws_ivschat_room", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The logging_configuration_identifiers attribute.
    /// </summary>
    public TerraformProperty<List<string>>? LoggingConfigurationIdentifiers
    {
        get => GetProperty<TerraformProperty<List<string>>>("logging_configuration_identifiers");
        set => this.WithProperty("logging_configuration_identifiers", value);
    }

    /// <summary>
    /// The maximum_message_length attribute.
    /// </summary>
    public TerraformProperty<double>? MaximumMessageLength
    {
        get => GetProperty<TerraformProperty<double>>("maximum_message_length");
        set => this.WithProperty("maximum_message_length", value);
    }

    /// <summary>
    /// The maximum_message_rate_per_second attribute.
    /// </summary>
    public TerraformProperty<double>? MaximumMessageRatePerSecond
    {
        get => GetProperty<TerraformProperty<double>>("maximum_message_rate_per_second");
        set => this.WithProperty("maximum_message_rate_per_second", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
