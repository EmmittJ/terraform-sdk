using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_docdb_orderable_db_instance.
/// </summary>
public class AwsDocdbOrderableDbInstanceDataSource : TerraformDataSource
{
    public AwsDocdbOrderableDbInstanceDataSource(string name) : base("aws_docdb_orderable_db_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("availability_zones");
        SetOutput("engine");
        SetOutput("engine_version");
        SetOutput("id");
        SetOutput("instance_class");
        SetOutput("license_model");
        SetOutput("preferred_instance_classes");
        SetOutput("region");
        SetOutput("vpc");
    }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public TerraformProperty<string> Engine
    {
        get => GetRequiredOutput<TerraformProperty<string>>("engine");
        set => SetProperty("engine", value);
    }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformProperty<string> EngineVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("engine_version");
        set => SetProperty("engine_version", value);
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
    /// The instance_class attribute.
    /// </summary>
    public TerraformProperty<string> InstanceClass
    {
        get => GetRequiredOutput<TerraformProperty<string>>("instance_class");
        set => SetProperty("instance_class", value);
    }

    /// <summary>
    /// The license_model attribute.
    /// </summary>
    public TerraformProperty<string> LicenseModel
    {
        get => GetRequiredOutput<TerraformProperty<string>>("license_model");
        set => SetProperty("license_model", value);
    }

    /// <summary>
    /// The preferred_instance_classes attribute.
    /// </summary>
    public List<TerraformProperty<string>> PreferredInstanceClasses
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("preferred_instance_classes");
        set => SetProperty("preferred_instance_classes", value);
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
    /// The vpc attribute.
    /// </summary>
    public TerraformProperty<bool> Vpc
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("vpc");
        set => SetProperty("vpc", value);
    }

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    public TerraformExpression AvailabilityZones => this["availability_zones"];

}
