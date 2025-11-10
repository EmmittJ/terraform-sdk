using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_api_gateway_resource resource.
/// </summary>
public class AwsApiGatewayResource : TerraformResource
{
    public AwsApiGatewayResource(string name) : base("aws_api_gateway_resource", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("path");
        SetOutput("id");
        SetOutput("parent_id");
        SetOutput("path_part");
        SetOutput("region");
        SetOutput("rest_api_id");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The parent_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParentId is required")]
    public required TerraformProperty<string> ParentId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("parent_id");
        set => SetProperty("parent_id", value);
    }

    /// <summary>
    /// The path_part attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PathPart is required")]
    public required TerraformProperty<string> PathPart
    {
        get => GetRequiredOutput<TerraformProperty<string>>("path_part");
        set => SetProperty("path_part", value);
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
    /// The rest_api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RestApiId is required")]
    public required TerraformProperty<string> RestApiId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("rest_api_id");
        set => SetProperty("rest_api_id", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformExpression Path => this["path"];

}
