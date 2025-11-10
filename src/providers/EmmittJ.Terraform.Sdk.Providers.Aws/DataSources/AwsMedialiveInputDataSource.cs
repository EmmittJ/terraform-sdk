using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_medialive_input.
/// </summary>
public class AwsMedialiveInputDataSource : TerraformDataSource
{
    public AwsMedialiveInputDataSource(string name) : base("aws_medialive_input", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("attached_channels");
        SetOutput("destinations");
        SetOutput("input_class");
        SetOutput("input_devices");
        SetOutput("input_partner_ids");
        SetOutput("input_source_type");
        SetOutput("media_connect_flows");
        SetOutput("name");
        SetOutput("role_arn");
        SetOutput("security_groups");
        SetOutput("sources");
        SetOutput("state");
        SetOutput("tags");
        SetOutput("type");
        SetOutput("id");
        SetOutput("region");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The attached_channels attribute.
    /// </summary>
    public TerraformExpression AttachedChannels => this["attached_channels"];

    /// <summary>
    /// The destinations attribute.
    /// </summary>
    public TerraformExpression Destinations => this["destinations"];

    /// <summary>
    /// The input_class attribute.
    /// </summary>
    public TerraformExpression InputClass => this["input_class"];

    /// <summary>
    /// The input_devices attribute.
    /// </summary>
    public TerraformExpression InputDevices => this["input_devices"];

    /// <summary>
    /// The input_partner_ids attribute.
    /// </summary>
    public TerraformExpression InputPartnerIds => this["input_partner_ids"];

    /// <summary>
    /// The input_source_type attribute.
    /// </summary>
    public TerraformExpression InputSourceType => this["input_source_type"];

    /// <summary>
    /// The media_connect_flows attribute.
    /// </summary>
    public TerraformExpression MediaConnectFlows => this["media_connect_flows"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformExpression RoleArn => this["role_arn"];

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public TerraformExpression SecurityGroups => this["security_groups"];

    /// <summary>
    /// The sources attribute.
    /// </summary>
    public TerraformExpression Sources => this["sources"];

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformExpression Type => this["type"];

}
