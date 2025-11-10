using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_bedrockagentcore_workload_identity resource.
/// </summary>
public class AwsBedrockagentcoreWorkloadIdentity : TerraformResource
{
    public AwsBedrockagentcoreWorkloadIdentity(string name) : base("aws_bedrockagentcore_workload_identity", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("workload_identity_arn");
        SetOutput("allowed_resource_oauth2_return_urls");
        SetOutput("name");
        SetOutput("region");
    }

    /// <summary>
    /// The allowed_resource_oauth2_return_urls attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> AllowedResourceOauth2ReturnUrls
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("allowed_resource_oauth2_return_urls");
        set => SetProperty("allowed_resource_oauth2_return_urls", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// The workload_identity_arn attribute.
    /// </summary>
    public TerraformExpression WorkloadIdentityArn => this["workload_identity_arn"];

}
