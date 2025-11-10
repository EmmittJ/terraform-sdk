using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_msk_configuration resource.
/// </summary>
public class AwsMskConfiguration : TerraformResource
{
    public AwsMskConfiguration(string name) : base("aws_msk_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("latest_revision");
        SetOutput("description");
        SetOutput("id");
        SetOutput("kafka_versions");
        SetOutput("name");
        SetOutput("region");
        SetOutput("server_properties");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
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
    /// The kafka_versions attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> KafkaVersions
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("kafka_versions");
        set => SetProperty("kafka_versions", value);
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
    /// The server_properties attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerProperties is required")]
    public required TerraformProperty<string> ServerProperties
    {
        get => GetRequiredOutput<TerraformProperty<string>>("server_properties");
        set => SetProperty("server_properties", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The latest_revision attribute.
    /// </summary>
    public TerraformExpression LatestRevision => this["latest_revision"];

}
