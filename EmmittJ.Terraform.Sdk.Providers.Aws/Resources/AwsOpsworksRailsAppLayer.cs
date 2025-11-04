using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_opsworks_rails_app_layer resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public class AwsOpsworksRailsAppLayer : TerraformResource
{
    public AwsOpsworksRailsAppLayer(string name) : base("aws_opsworks_rails_app_layer", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The app_server attribute.
    /// </summary>
    public string? AppServer
    {
        get => GetProperty<TerraformLiteralProperty<string>>("app_server")?.Value;
        set => this.WithProperty("app_server", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The auto_assign_elastic_ips attribute.
    /// </summary>
    public bool? AutoAssignElasticIps
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("auto_assign_elastic_ips")?.Value;
        set => this.WithProperty("auto_assign_elastic_ips", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The auto_assign_public_ips attribute.
    /// </summary>
    public bool? AutoAssignPublicIps
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("auto_assign_public_ips")?.Value;
        set => this.WithProperty("auto_assign_public_ips", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The auto_healing attribute.
    /// </summary>
    public bool? AutoHealing
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("auto_healing")?.Value;
        set => this.WithProperty("auto_healing", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The bundler_version attribute.
    /// </summary>
    public string? BundlerVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bundler_version")?.Value;
        set => this.WithProperty("bundler_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The custom_configure_recipes attribute.
    /// </summary>
    public List<string>? CustomConfigureRecipes
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("custom_configure_recipes")?.Value;
        set => this.WithProperty("custom_configure_recipes", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The custom_deploy_recipes attribute.
    /// </summary>
    public List<string>? CustomDeployRecipes
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("custom_deploy_recipes")?.Value;
        set => this.WithProperty("custom_deploy_recipes", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The custom_instance_profile_arn attribute.
    /// </summary>
    public string? CustomInstanceProfileArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("custom_instance_profile_arn")?.Value;
        set => this.WithProperty("custom_instance_profile_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The custom_json attribute.
    /// </summary>
    public string? CustomJson
    {
        get => GetProperty<TerraformLiteralProperty<string>>("custom_json")?.Value;
        set => this.WithProperty("custom_json", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The custom_security_group_ids attribute.
    /// </summary>
    public HashSet<string>? CustomSecurityGroupIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("custom_security_group_ids")?.Value;
        set => this.WithProperty("custom_security_group_ids", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The custom_setup_recipes attribute.
    /// </summary>
    public List<string>? CustomSetupRecipes
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("custom_setup_recipes")?.Value;
        set => this.WithProperty("custom_setup_recipes", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The custom_shutdown_recipes attribute.
    /// </summary>
    public List<string>? CustomShutdownRecipes
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("custom_shutdown_recipes")?.Value;
        set => this.WithProperty("custom_shutdown_recipes", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The custom_undeploy_recipes attribute.
    /// </summary>
    public List<string>? CustomUndeployRecipes
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("custom_undeploy_recipes")?.Value;
        set => this.WithProperty("custom_undeploy_recipes", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The drain_elb_on_shutdown attribute.
    /// </summary>
    public bool? DrainElbOnShutdown
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("drain_elb_on_shutdown")?.Value;
        set => this.WithProperty("drain_elb_on_shutdown", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The elastic_load_balancer attribute.
    /// </summary>
    public string? ElasticLoadBalancer
    {
        get => GetProperty<TerraformLiteralProperty<string>>("elastic_load_balancer")?.Value;
        set => this.WithProperty("elastic_load_balancer", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The install_updates_on_boot attribute.
    /// </summary>
    public bool? InstallUpdatesOnBoot
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("install_updates_on_boot")?.Value;
        set => this.WithProperty("install_updates_on_boot", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The instance_shutdown_timeout attribute.
    /// </summary>
    public double? InstanceShutdownTimeout
    {
        get => GetProperty<TerraformLiteralProperty<double>>("instance_shutdown_timeout")?.Value;
        set => this.WithProperty("instance_shutdown_timeout", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The manage_bundler attribute.
    /// </summary>
    public bool? ManageBundler
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("manage_bundler")?.Value;
        set => this.WithProperty("manage_bundler", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The passenger_version attribute.
    /// </summary>
    public string? PassengerVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("passenger_version")?.Value;
        set => this.WithProperty("passenger_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ruby_version attribute.
    /// </summary>
    public string? RubyVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ruby_version")?.Value;
        set => this.WithProperty("ruby_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The rubygems_version attribute.
    /// </summary>
    public string? RubygemsVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("rubygems_version")?.Value;
        set => this.WithProperty("rubygems_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The stack_id attribute.
    /// </summary>
    public string? StackId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("stack_id")?.Value;
        set => this.WithProperty("stack_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The system_packages attribute.
    /// </summary>
    public HashSet<string>? SystemPackages
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("system_packages")?.Value;
        set => this.WithProperty("system_packages", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The use_ebs_optimized_instances attribute.
    /// </summary>
    public bool? UseEbsOptimizedInstances
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("use_ebs_optimized_instances")?.Value;
        set => this.WithProperty("use_ebs_optimized_instances", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
