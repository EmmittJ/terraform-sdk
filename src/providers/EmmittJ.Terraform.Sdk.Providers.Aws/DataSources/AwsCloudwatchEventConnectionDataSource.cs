using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_cloudwatch_event_connection Terraform data source.
/// Retrieves information about a aws_cloudwatch_event_connection.
/// </summary>
public partial class AwsCloudwatchEventConnectionDataSource(string name) : TerraformDataSource("aws_cloudwatch_event_connection", name)
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The authorization_type attribute.
    /// </summary>
    public TerraformValue<string> AuthorizationType
    {
        get => new TerraformReference<string>(this, "authorization_type");
    }

    /// <summary>
    /// The kms_key_identifier attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyIdentifier
    {
        get => new TerraformReference<string>(this, "kms_key_identifier");
    }

    /// <summary>
    /// The secret_arn attribute.
    /// </summary>
    public TerraformValue<string> SecretArn
    {
        get => new TerraformReference<string>(this, "secret_arn");
    }

}
