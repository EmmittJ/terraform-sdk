using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_bedrockagentcore_workload_identity Terraform resource.
/// Manages a aws_bedrockagentcore_workload_identity resource.
/// </summary>
public partial class AwsBedrockagentcoreWorkloadIdentity(string name) : TerraformResource("aws_bedrockagentcore_workload_identity", name)
{
    /// <summary>
    /// The allowed_resource_oauth2_return_urls attribute.
    /// </summary>
    public TerraformSet<string>? AllowedResourceOauth2ReturnUrls
    {
        get => GetArgument<TerraformSet<string>>("allowed_resource_oauth2_return_urls");
        set => SetArgument("allowed_resource_oauth2_return_urls", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
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
    /// The workload_identity_arn attribute.
    /// </summary>
    public TerraformValue<string> WorkloadIdentityArn
        => AsReference("workload_identity_arn");

}
