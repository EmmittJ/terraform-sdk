using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iam_security_token_service_preferences resource.
/// </summary>
public class AwsIamSecurityTokenServicePreferences : TerraformResource
{
    public AwsIamSecurityTokenServicePreferences(string name) : base("aws_iam_security_token_service_preferences", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("global_endpoint_token_version");
        SetOutput("id");
    }

    /// <summary>
    /// The global_endpoint_token_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GlobalEndpointTokenVersion is required")]
    public required TerraformProperty<string> GlobalEndpointTokenVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("global_endpoint_token_version");
        set => SetProperty("global_endpoint_token_version", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

}
